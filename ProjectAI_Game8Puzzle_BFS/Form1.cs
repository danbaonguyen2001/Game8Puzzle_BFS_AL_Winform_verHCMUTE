using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAI_Game8Puzzle_BFS
{
    public partial class Form1 : Form
    {
		private SoundPlayer soundPlayer;
		private bool isUpLoad = false;
		
		string FileName;
        int chiSoOTrong, soBuocDi = 0;
        List<Bitmap> mangGoc = new List<Bitmap>();
		List<Bitmap> mangUpLoad = new List<Bitmap>();
		List<int> mangHienTai = new List<int> { };
        //khởi tạo phương thức đo thời gian trôi qua
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        List<State> ketQuaCuoiCung = new List<State>();
        int currentState = 0;

        List<int> mangCuoi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Test case 
        List<int> tesCase1 = new List<int> { 1, 2, 9, 3, 4, 6, 7, 5, 8 }; //trường hợp đb bfs 15/ tối ưu 89
        List<int> tesCase2 = new List<int> { 4, 5, 9, 3, 1, 6, 7, 2, 8 }; //15 nhưng khác Number of browsing steps
        List<int> tesCase3 = new List<int> { 4, 9, 5, 3, 1, 6, 7, 2, 8 }; //14 tương tự như 15
        List<int> tesCase4 = new List<int> { 9, 1, 2, 3, 6, 5, 4, 8, 7 }; //bfs không ra, tối ưu ra 53
        List<int> tesCase5 = new List<int> { 9, 1, 3, 2, 6, 5, 4, 7, 8 };//bfs 15 nhưng lâu, tối ưu 37 nhưng nhanh


        List<List<int>> mangTestCase = new List<List<int>>();
        public Form1()
        {
            InitializeComponent();
			this.Text = "8 PUZZLE version HCMUTE ";

			// Add test case
			mangTestCase.Add(tesCase1);
			mangTestCase.Add(tesCase2);
			mangTestCase.Add(tesCase3);
			mangTestCase.Add(tesCase4);
			mangTestCase.Add(tesCase5);

			//Khoi tai audio
			soundPlayer = new SoundPlayer("LetMeDownSlowlyPianoCover-Piano-5942133_hq.wav");
			
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			isUpLoad = false;
			soundPlayer.Play();
			lblBuocDi.Text += soBuocDi;
			lblThoiGianDem.Text = "00:00:00";
			ChoiLai();


        }

        private void ChoiLai()
        {
			//đoạn code comment sau dùng để random ngẫu nhiên các trạng thái, nếu số ô bị sai quá nhiều thuật toán sẽ k chạy được
			//List<int> mangRandom = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
			//do
			//{
			//  int j;
			//	//thư viện LinQ hổ trợ hàm trộn mảng (search trên stackoverflow)
			//	mangRandom = mangRandom.OrderBy(a => Guid.NewGuid()).ToList();

			//  for (int i = 0; i < 9; i++)
			//  {
			//		((PictureBox)gbKhung.Controls[i]).Image = mangGoc[mangRandom[i]-1];
			//		if (mangRandom[i] == 9)
			//			chiSoOTrong = i;
			//	}
			//} while (KiemTraWin());
			//return mangRandom;

			lblTimeGiai.Text = "Solution time  : 0.0 ms";
			lblBuocDuyet.Text = "Number of browsing steps: 0";

			Random r = new Random();
			int j = r.Next(0, 5);
			//j = 2;
			List<int> mangRandom = mangTestCase[j];
			mangHienTai = mangRandom;
			if (isUpLoad==true)
            {				
				CutImage(FileName);
				do
				{
					for (int i = 0; i < 9; i++)
					{
						
						if (mangRandom[i] == 9)     // Lay vi tri o trong
							chiSoOTrong = i;
					}
				} while (KiemTraWin());
				
				
			}

            else
            {
				mangGoc.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4,
			Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._null });

				do
				{
					for (int i = 0; i < 9; i++)
					{
						((PictureBox)gbKhung.Controls[i]).Image = mangGoc[mangRandom[i] - 1];
						if (mangRandom[i] == 9)     // Lay vi tri o trong
							chiSoOTrong = i;
					}
				} while (KiemTraWin());
				//mangHienTai = mangRandom;							
			}
			//return mangRandom;
		}		
		

		private void btnChoiLai_Click(object sender, EventArgs e)
        {
			//gbAnhGoc.BackgroundImage = Properties.Resources.hqdefault;

			//if (lblThoiGianDem.Text != "00:00:00")
			//{

			//}
			DialogResult YesOrNo = new DialogResult();
			YesOrNo = MessageBox.Show("Do you want to play again?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (YesOrNo == DialogResult.Yes || lblThoiGianDem.Text == "00:00:00")
            {
				//nếu người chơi chọn đồng ý chơi lại hoặc thời gian còn là chưa bắt đầu thì reset lại
				// tất cả các thông số như là đếm thời gian, Number of steps.
				ChoiLai();				
                timer.Reset();
                lblThoiGianDem.Text = "00:00:00";
				soBuocDi = 0;
                lblBuocDi.Text = "Number of steps: 0";
            }
        }

        private void KiemTraThoatChuongTrinh(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnThoat && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnThoat && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			KiemTraThoatChuongTrinh(sender, e as FormClosingEventArgs);
		}
		

		private void btnGiai_Click(object sender, EventArgs e)
        {
			timer.Stop();
			//List<int> mangDau = ChoiLai();			
            State trThaiDau = new State(mangHienTai);
            State trThaiCuoi = new State(mangCuoi);
            BFS bfs = new BFS(trThaiDau, trThaiCuoi);

			Stopwatch timer_tmp = new Stopwatch();
			timer_tmp.Reset();
			lblTimeGiai.Text = "Solution time : 0.0 ms";
			timer_tmp.Start();
			if (timer.ElapsedMilliseconds == 3)
			{
				DialogResult OK = MessageBox.Show("Couldn't find the answer!!", "the game is easy", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if(OK==DialogResult.OK) ChoiLai();
			}
			this.ketQuaCuoiCung = bfs.Solve();

			timer.Stop();
			lblTimeGiai.Text = "Solution time : " + timer_tmp.Elapsed.TotalMilliseconds.ToString() + " ms";

			//đảo mảng lại vì kqua tra về là đường đi ngược từ dưới lên
			this.ketQuaCuoiCung.Reverse();
			this.lblBuocDuyet.Text = "Number of browsing steps: " + bfs.dem.ToString();
			this.currentState = 0;

			this.lblBuocDi.Text = "Number of steps: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

			State tmp = this.ketQuaCuoiCung[this.currentState];
			List<int> mang = tmp.trangThai;
			LoadImage(mang);
		}
		
		private void CachThucDiChuyen(object sender, EventArgs e)
        {
			btnTamDung.Enabled = true;
            if (lblThoiGianDem.Text == "00:00:00")
                timer.Start();
            int oNguoiDungChon = gbKhung.Controls.IndexOf(sender as Control);
            if (chiSoOTrong != oNguoiDungChon)
            {
				//tìm ra danh sách những số họ hàng với số ô người dùng chọn
                List<int> danhSachCacChiSoHoHang = new List<int>(new int[] { ((oNguoiDungChon % 3 == 0) ? -1 : oNguoiDungChon - 1), 
					oNguoiDungChon - 3, (oNguoiDungChon % 3 == 2) ? -1 : 
					oNguoiDungChon + 1, oNguoiDungChon + 3 });
				//nếu ô đen trống mà nằm trong ds này có nghĩa là có thể đi được.
                if (danhSachCacChiSoHoHang.Contains(chiSoOTrong))
                {
					
					//gán ô trống thành ô hình người dùng chọn, và gán ô người dùng chọn thành ô đen trống là ptu thứ 9 trong mảng gốc
                    ((PictureBox)gbKhung.Controls[chiSoOTrong]).Image = ((PictureBox)gbKhung.Controls[oNguoiDungChon]).Image;
                    
                    if (isUpLoad == true)
                    {
						((PictureBox)gbKhung.Controls[oNguoiDungChon]).Image = mangUpLoad[8];
					}
                    else
                    {
						((PictureBox)gbKhung.Controls[oNguoiDungChon]).Image = mangGoc[8];
					}

					int temp = mangHienTai[chiSoOTrong];
					mangHienTai[chiSoOTrong] = mangHienTai[oNguoiDungChon];
					mangHienTai[oNguoiDungChon] = temp;

					chiSoOTrong = oNguoiDungChon;
                    lblBuocDi.Text = "Number of steps: " + (++soBuocDi);
                    if (KiemTraWin())
                    {
                        timer.Stop();
                        (gbKhung.Controls[8] as PictureBox).Image = mangGoc[8];
                        MessageBox.Show("Congratulations on winning the game...\nTime : " + timer.Elapsed.ToString().Remove(8) + "\nNumber of steps : " + soBuocDi, "Game Ghép Hình");
						soBuocDi = 0;
                        lblBuocDi.Text = "Number of steps: 0";
                        lblThoiGianDem.Text = "00:00:00";
                        timer.Reset();
						btnTamDung.Enabled = false;
						ChoiLai();
                    }
                }
            }
        }

        bool KiemTraWin()
        {
			//so với mảng gốc là hình ảnh gốc đã set theo thứ tự ban đầu, nếu trong quá trình duyệt có cái nào k đúng
			//thì lập tức break ra =>false, ngược lại đến 8 vẫn đúng thì trả về true
            int i;
            if (isUpLoad)
            {
				for (i = 0; i < 8; i++)
				{
					if ((gbKhung.Controls[i] as PictureBox).Image != mangUpLoad[i])
						break;
				}
			}
            for (i = 0; i < 8; i++)
            {
                if ((gbKhung.Controls[i] as PictureBox).Image != mangGoc[i])
					break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void TinhThoiGian(object sender, EventArgs e)
        {
			//nếu người chơi bắt đầu click vào các ô ngoại trừ ô số 8 là ô đen trống thì bắt đầu đếm thời gian
            if (timer.Elapsed.ToString() != "00:00:00")
                lblThoiGianDem.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnTamDung.Enabled = false;
            else
                btnTamDung.Enabled = true;
			//giới hạn lại thời gian chơi game thì mở code ra, tùy chỉnh theo tgian mình muốn ngay chổ
			

            if (timer.Elapsed.Minutes.ToString() == "3")
            {
                timer.Reset();
                lblBuocDi.Text = "Number of steps : 0";
                lblThoiGianDem.Text = "00:00:00";
				soBuocDi = 0;
                btnTamDung.Enabled = false;
                MessageBox.Show("Time up!");
				ChoiLai();
            }
        }

        private void btnDiLui_Click(object sender, EventArgs e)
        {
			//nút lui lại đến trạng thái cuối cùng rồi thì ngưng nên mới có điều kiện > 0
			if(currentState > 0)
			{
				currentState -= 1;

				this.lblBuocDi.Text = "Number of steps: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

				State trt = ketQuaCuoiCung[currentState];

				TheHienBuocDi(trt);
			}		
		}

        private void btnDiToi_Click(object sender, EventArgs e)
        {
			//nút lui tới đến trạng thái cuối cùng rồi thì ngưng nên mới có điều kiện < chiều dài của dsach đường đi tìm dc
			if (currentState < ketQuaCuoiCung.Count - 1)
			{
				currentState += 1;

				this.lblBuocDi.Text = "Number of steps: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

				State trt = ketQuaCuoiCung[currentState];

				//for (int j = 0; j < trt.trangThai.Count; j++)
				//{
				//	((PictureBox)gbKhung.Controls[j]).Image = mangUpLoad[trt.trangThai[j] - 1];
				//}

				TheHienBuocDi(trt);
			}

            if (currentState == ketQuaCuoiCung.Count - 1)
            {
				DialogResult OK = MessageBox.Show("The machine has found the answer!!", "The game is easy", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (OK == DialogResult.OK) {
					ChoiLai();
					lblThoiGianDem.Text = "00:00:00";
					timer.Reset();
					lblBuocDi.Text = "Number of steps:";
				} 
			}
		}

        private void btnGiaiToiUu_Click(object sender, EventArgs e)
		{
			//List<int> mangDau = ChoiLai();
			//List<int> mangDau = new List<int> { 1, 2, 9, 3, 4, 6, 7, 5, 8 };
			//List<int> mangCuoi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			timer.Stop();
			State trThaiDau = new State(mangHienTai);
			State trThaiCuoi = new State(mangCuoi);
			BFS bfs = new BFS(trThaiDau, trThaiCuoi);

			Stopwatch timer_tmp = new Stopwatch();
			timer_tmp.Reset();
			lblTimeGiai.Text = "Solution time : 0.0 ms";
			timer_tmp.Start();

			this.ketQuaCuoiCung = bfs.Solve_BestFirstSearch();
			
			timer.Stop();
			lblTimeGiai.Text = "Solution time : " + timer_tmp.Elapsed.TotalMilliseconds.ToString() + " ms";

			//đảo mảng lại vì kqua tra về là đường đi ngược từ dưới lên
			this.ketQuaCuoiCung.Reverse();
			this.lblBuocDuyet.Text = "Number of browsing steps: " + bfs.dem.ToString();

			this.currentState = 0;
			this.lblBuocDi.Text = "Number of steps: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();
			State tmp = this.ketQuaCuoiCung[this.currentState];
			List<int> mang = tmp.trangThai;
			LoadImage(mang);
		}

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnTamDung.Text == "Pause")
            {
                timer.Stop();
                gbKhung.Visible = false;
                btnTamDung.Text = "Play";
            }
            else
            {
                timer.Start();
                gbKhung.Visible = true;
                btnTamDung.Text = "Pause";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
			lblBuocDi.Text = "Number of steps:";
			isUpLoad = true;
			string fileName = string.Empty;

			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			opnfd.Multiselect = true;
			if (opnfd.ShowDialog() == DialogResult.OK)
			{
				gbAnhGoc.BackgroundImage = new Bitmap(opnfd.FileName);				
				CutImage(opnfd.FileName);
			}
			
			lblThoiGianDem.Text = "00:00:00";
			timer.Reset();
			//ChoiLai();

			FileName = opnfd.FileName;

			
		}
		

        private void CutImage(string path)
        {

			
			var imgarray = new Image[9];
			var img = Image.FromFile(path);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					var index = i * 3 + j;
					imgarray[index] = new Bitmap(150, 150); //defaul 104
					var graphics = Graphics.FromImage(imgarray[index]);
					graphics.DrawImage(img, new Rectangle(0, 0, 150, 150), new Rectangle(i * 150, j * 150, 150, 150), GraphicsUnit.Pixel);
					graphics.Dispose();
				}
			}

			//
					
			if(mangUpLoad.Count>0) mangUpLoad.RemoveRange(0, 9);       // Xoa mang hinh hien tai	
			mangUpLoad.AddRange(new Bitmap[] {(Bitmap)imgarray[0],(Bitmap)imgarray[3],(Bitmap)imgarray[6],(Bitmap)imgarray[1],
                (Bitmap)imgarray[4],(Bitmap)imgarray[7],(Bitmap)imgarray[2],(Bitmap)imgarray[5],Properties.Resources._null });

            //mangUpLoad.AddRange(new Bitmap[] {(Bitmap)imgarray[0],(Bitmap)imgarray[1],(Bitmap)imgarray[2],(Bitmap)imgarray[3],
            //    (Bitmap)imgarray[4],(Bitmap)imgarray[5],(Bitmap)imgarray[6],(Bitmap)imgarray[7],Properties.Resources._null });

            //pbx1.Image = imgarray[mangHienTai[0]-1];
            //         pbx2.Image = imgarray[mangHienTai[1]-1];
            //         pbx3.Image = imgarray[mangHienTai[2]-1];

            //         pbx4.Image = imgarray[mangHienTai[3]-1];
            //         pbx5.Image = imgarray[mangHienTai[4]-1];
            //         pbx6.Image = imgarray[mangHienTai[5]-1];

            //         pbx7.Image = imgarray[mangHienTai[6]-1];
            //         pbx8.Image = imgarray[mangHienTai[7]-1];
            //         pbx9.Image = imgarray[mangHienTai[8]-1];

            do
			{
				for (int i = 0; i < 9; i++)
				{
					((PictureBox)gbKhung.Controls[i]).Image = mangUpLoad[mangHienTai[i] - 1];
					if (mangHienTai[i] == 9)     // Lay vi tri o trong
						chiSoOTrong = i;
				}
			} while (KiemTraWin());

			//for (int i = 0; i < 9; i++)		{
				
			//	if (mangHienTai[i] == 9)
   //             {
			//		chiSoOTrong = i;
			//		((PictureBox)gbKhung.Controls[i]).Image = Properties.Resources._null;
			//	}  
			//}

			
		}

		private void LoadImage(List<int> mang)
        {
			for(int k = 0; k < mang.Count; k++)
            {
				Console.WriteLine(mang[k]);
			}
			
			if (isUpLoad == true)
            {
				for (int i = 0; i < mang.Count; i++)
				{
					((PictureBox)gbKhung.Controls[i]).Image = mangUpLoad[mang[i]-1];
				}
			}
            else
            {
				for (int j = 0; j < mang.Count; j++)
				{
					((PictureBox)gbKhung.Controls[j]).Image = mangGoc[mang[j] - 1];
				}
			}
        }

        private void TheHienBuocDi(State state)
        {
			//Console.WriteLine(isUpLoad);
			if (isUpLoad == true)
			{
				for (int j = 0; j < state.trangThai.Count; j++)
				{
					((PictureBox)gbKhung.Controls[j]).Image = mangUpLoad[state.trangThai[j] - 1];					
				}
				
			}
			else
			{
				for (int j = 0; j < state.trangThai.Count; j++)
				{
					((PictureBox)gbKhung.Controls[j]).Image = mangGoc[state.trangThai[j] - 1];
				}
			}
		}
		

	}
}
