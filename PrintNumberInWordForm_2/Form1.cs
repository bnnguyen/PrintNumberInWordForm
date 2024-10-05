using System;
using System.Net;
using System.Web;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace PrintNumberInWordForm_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mode = 2;

        string Viet(string t)
        {
            string ans = "", anst1 = "", anst2 = "";
            string[] num = new string[10] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] place = new string[4] { "", "ngàn", "triệu", "tỉ" };
            int i = t.Length, cnt = 0;
            while (i - 3 >= 0)
            {
                anst2 = place[(cnt - 1) % 3 + 1] + " ";
                if (cnt % 3 == 0 && cnt >= 3)
                {
                    anst2 = "";
                    anst1 = "tỉ " + anst1;
                }
                if (t[i - 1] == '0' && t[i - 2] == '0' && t[i - 3] == '0')
                {
                    i -= 3;
                    cnt++;
                    continue;
                }
                else if (t[i - 2] == '0' && t[i - 1] == '0') ans = num[t[i - 3] - '0'] + " trăm " + anst2 + anst1 + ans;
                else if (t[i - 2] == '0') ans = num[t[i - 3] - '0'] + " trăm lẻ " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                else
                {
                    if (t[i - 2] == '1')
                    {
                        if (t[i - 1] == '0') ans = num[t[i - 3] - '0'] + " trăm mười " + anst2 + anst1 + ans;
                        else if (t[i - 1] == '5') ans = num[t[i - 3] - '0'] + " trăm mười lăm " + anst2 + anst1 + ans;
                        else ans = num[t[i - 3] - '0'] + " trăm mười " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                    }
                    else
                    {
                        if (t[i - 1] == '0') ans = num[t[i - 3] - '0'] + " trăm " + num[t[i - 2] - '0'] + " mươi " + anst2 + anst1 + ans;
                        else if (t[i - 1] == '1') ans = num[t[i - 3] - '0'] + " trăm " + num[t[i - 2] - '0'] + " mươi mốt " + anst2 + anst1 + ans;
                        else if (t[i - 1] == '5') ans = num[t[i - 3] - '0'] + " trăm " + num[t[i - 2] - '0'] + " mươi lăm " + anst2 + anst1 + ans;
                        else ans = num[t[i - 3] - '0'] + " trăm " + num[t[i - 2] - '0'] + " mươi " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                    }
                }
                i -= 3;
                cnt++;
            }
            anst2 = place[(cnt - 1) % 3 + 1] + " ";
            if (cnt % 3 == 0 && cnt >= 3)
            {
                anst2 = "";
                anst1 = " tỉ " + anst1;
            }
            if (i == 1) ans = num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
            if (i == 2)
            {
                if (t[i - 2] == '1')
                {
                    if (t[i - 1] == '0') ans = " mười " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '5') ans = " mười lăm " + anst2 + anst1 + ans;
                    else ans = " mười " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                }
                else
                {
                    if (t[i - 1] == '0') ans = num[t[i - 2] - '0'] + " mươi " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '1') ans = num[t[i - 2] - '0'] + " mươi mốt " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '5') ans = num[t[i - 2] - '0'] + " mươi lăm " + anst2 + anst1 + ans;
                    else ans = num[t[i - 2] - '0'] + " mươi " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                }
            }
            return ans;
        }

        string Eng(string t)
        {
            string ans = "", anst1 = "", anst2 = "";
            string[] num = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] place = new string[4] { "", "thousand", "million", "billion" };
            int i = t.Length, cnt = 0;
            while (i - 3 >= 0)
            {
                anst2 = place[(cnt - 1) % 3 + 1] + " ";
                if (cnt % 3 == 0 && cnt >= 3)
                {
                    anst2 = "";
                    anst1 = "billion " + anst1;
                }
                if (t[i - 1] == '0' && t[i - 2] == '0' && t[i - 3] == '0')
                {
                    i -= 3;
                    cnt++;
                    continue;
                }
                else if (t[i - 2] == '0' && t[i - 1] == '0')
                {
                    if (t[i - 3] == '0') ans = anst2 + anst1 + ans;
                    else ans = num[t[i - 3] - '0'] + " hundred " + anst2 + anst1 + ans;

                }
                else if (t[i - 2] == '0')
                {
                    if (t[i - 3] == '0') ans = " and " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                    else ans = num[t[i - 3] - '0'] + " hundred and " + num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
                }
                else
                {
                    if (t[i - 2] == '1')
                    {
                        string tmp = "";
                        if (t[i - 3] != '0') tmp = num[t[i - 3] - '0'] + " hundred ";
                        if (t[i - 1] == '0') tmp = tmp + "and ten ";
                        else if (t[i - 1] == '1') tmp = tmp + "and eleven ";
                        else if (t[i - 1] == '2') tmp = tmp + "and twelve ";
                        else if (t[i - 1] == '3') tmp = tmp + "and thirteen ";
                        else if (t[i - 1] == '4') tmp = tmp + "and fourteen ";
                        else if (t[i - 1] == '5') tmp = tmp + "and fifteen ";
                        else if (t[i - 1] == '6') tmp = tmp + "and sixteen ";
                        else if (t[i - 1] == '7') tmp = tmp + "and seventeen ";
                        else if (t[i - 1] == '8') tmp = tmp + "and eighteen ";
                        else if (t[i - 1] == '9') tmp = tmp + "and nineteen ";
                        ans = tmp + anst2 + anst1 + ans;
                    }
                    else
                    {
                        string tmp = "";
                        if (t[i - 1] != '0') tmp = tmp + num[t[i - 1] - '0'] + " ";
                        if (t[i - 2] == '2') tmp = "and twenty " + tmp;
                        else if (t[i - 2] == '3') tmp = "and thirty " + tmp;
                        else if (t[i - 2] == '4') tmp = "and fourty " + tmp;
                        else if (t[i - 2] == '5') tmp = "and fifty " + tmp;
                        else if (t[i - 2] == '6') tmp = "and sixty " + tmp;
                        else if (t[i - 2] == '7') tmp = "and seventy " + tmp;
                        else if (t[i - 2] == '8') tmp = "and eighty " + tmp;
                        else if (t[i - 2] == '9') tmp = "and ninety " + tmp;
                        if (t[i - 3] != '0') tmp = num[t[i - 3] - '0'] + " hundred " + tmp;
                        ans = tmp + anst2 + anst1 + ans;
                    }
                }
                i -= 3;
                cnt++;
            }
            anst2 = place[(cnt - 1) % 3 + 1] + " ";
            if (cnt % 3 == 0 && cnt >= 3)
            {
                anst2 = "";
                anst1 = "billion " + anst1;
            }
            if (i == 1) ans = num[t[i - 1] - '0'] + " " + anst2 + anst1 + ans;
            if (i == 2)
            {
                if (t[i - 2] == '1')
                {
                    if (t[i - 1] == '0') ans = "ten " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '1') ans = "eleven " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '2') ans = "twelve " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '3') ans = "thirteen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '4') ans = "fourteen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '5') ans = "fifteen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '6') ans = "sixteen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '7') ans = "seventeen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '8') ans = "eighteen " + anst2 + anst1 + ans;
                    else if (t[i - 1] == '9') ans = "nineteen " + anst2 + anst1 + ans;
                }
                else
                {
                    string tmp = "";
                    if (t[i - 1] != '0') tmp = tmp + num[t[i - 1] - '0'] + " ";
                    if (t[i - 2] == '2') tmp = "twenty " + tmp;
                    else if (t[i - 2] == '3') tmp = "thirty " + tmp;
                    else if (t[i - 2] == '4') tmp = "fourty " + tmp;
                    else if (t[i - 2] == '5') tmp = "fifty " + tmp;
                    else if (t[i - 2] == '6') tmp = "sixty " + tmp;
                    else if (t[i - 2] == '7') tmp = "seventy " + tmp;
                    else if (t[i - 2] == '8') tmp = "eighty " + tmp;
                    else if (t[i - 2] == '9') tmp = "ninety " + tmp;
                    ans = tmp + anst2 + anst1 + ans;
                }
            }
            return ans;
        }

        string afterTouch(string t)
        {
            string word = "";
            string[] words = new string[1000001];
            int id = 0;
            words[id++] = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != ' ')
                    word += t[i];
                else if (i > 0 && t[i] == ' ' && t[i - 1] != ' ')
                {
                    words[id] = word;
                    id++;
                    word = "";
                }
            }
            string ans = "";
            bool[] streakCnt = new bool[1001];
            for (int i = 1; i <= 1000; i++)
                streakCnt[i] = false;
            int streak = 0;
            for (int i = id-1; i > 0; i--)
            {
                if (words[i] == "tỉ" || words[i] == "billion")
                    streak++;
                else
                {
                    if (streak != 0 && !streakCnt[streak])
                    {
                        for (int j = 1; j <= streak; j++)
                            ans = words[i + 1] + " " + ans;
                        streakCnt[streak] = true;
                    }
                    streak = 0;
                    ans = words[i] + " " + ans;
                }
            }
            return ans;
        }

        private void txt_inp_TextChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < txt_inp.Text.Length; j++)
            {
                if (txt_inp.Text[j] == ',')
                    txt_inp.Text = txt_inp.Text.Remove(j, 1);
            }
            if (mode == 2)
            {
                txt_out.Text = Viet(txt_inp.Text);
            }
            else
            {
                txt_out.Text = Eng(txt_inp.Text);
            }
            txt_out.Text = afterTouch(txt_out.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 2)
            {
                txt_out.Text = Eng(txt_inp.Text);
                txt_out.Text = afterTouch(txt_out.Text);

                button1.Text = "English";
                button2.Text = "Tiếng Việt";
                lb_inp.Text = "TYPE NUMBER: ";
                lb_out.Text = "WORD FORM: ";
                button3.Text = "READ";
                mode = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                txt_out.Text = Viet(txt_inp.Text);
                txt_out.Text = afterTouch(txt_out.Text);

                button1.Text = "English";
                button2.Text = "Tiếng Việt";
                lb_inp.Text = "NHẬP SỐ: ";
                lb_out.Text = "DẠNG CHỮ: ";
                button3.Text = "ĐỌC SỐ";
                mode = 2;
            }
        }

        void PlayMp3FromUrl(string url)
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream stream = WebRequest.Create(url)
                    .GetResponse().GetResponseStream())
                {
                    byte[] buffer = new byte[32768];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                }

                ms.Position = 0;
                using (WaveStream blockAlignedStream =
                    new BlockAlignReductionStream(
                        WaveFormatConversionStream.CreatePcmStream(
                            new Mp3FileReader(ms))))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }

        private void txt_inp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                int position = txt_inp.SelectionStart;
                if (position == 0) e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right) e.Handled = false;
            else e.Handled = true;
        }

        private void txt_cheat_TextChanged(object sender, EventArgs e)
        {
            txt_inp.Text = txt_cheat.Text;

            string tmp = "";
            int cnt = 0, position = txt_cheat.SelectionStart, oldLen = txt_cheat.Text.Length;
            int newpos = -1;
            for (int j = txt_cheat.Text.Length-1; j >= 0; j--)
            {
                if (txt_cheat.Text[j] == ',')
                {
                    continue;
                }
                else
                {
                    if (j < position) newpos++;
                }
                if (j == 0 && txt_cheat.Text[j] == '0' && cnt > 0) continue;
                cnt++;
                if (cnt == 4)
                {
                    tmp = txt_cheat.Text[j] + "," + tmp;
                    if (j < position)
                        newpos++;
                    cnt = 1;
                }
                else
                    tmp = txt_cheat.Text[j] + tmp;
            }
            txt_cheat.Text = tmp;
            txt_cheat.SelectionStart = newpos+1;
        }

        private void txt_cheat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                int position = txt_cheat.SelectionStart;
                if (position == 0 && txt_cheat.Text.Length == 0) e.Handled = false;
                else if (position == 0 && txt_cheat.Text.Length > 0) e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right) e.Handled = false;
            else if (e.KeyChar == ',') e.Handled = true;
            else e.Handled = true;
        }

        bool inTi(string t)
        {
            if (t == "tỉ" || t == "billion") return true;
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string t = txt_out.Text, word = "";
            string[] words = new string[1000001];
            int id = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != ' ')
                {
                    word += t[i];
                }
                else if (i > 0 && t[i] == ' ' && t[i - 1] != ' ') 
                {
                    words[id] = word;
                    id++;
                    word = "";
                }
            }

            string[] wordchain = new string[1000001];
            int idchain = 0, streak = 0;
            string chain = "";
            words[id + 1] = "bleh";
            for (int i = 0; i < id; i++)
            {
                if (chain != "") chain += ' ';
                chain += words[i];
                if (inTi(words[i]) && inTi(words[i+1]))
                {
                    streak++;
                    if (streak == 10)
                    {
                        wordchain[idchain] = chain;
                        chain = "";
                        idchain++;
                        streak = 0;
                    }
                }
                if (inTi(words[i]) && !inTi(words[i+1]))
                {
                    wordchain[idchain] = chain;
                    chain = "";
                    idchain++;
                }
            }
            if (chain != "") wordchain[idchain++] = chain;

            string language;

            if (mode == 2)
            {
                language = "vi";
                button3.Text = "ĐANG ĐỌC SỐ...";
            }
            else
            {
                language = "en";
                button3.Text = "READING...";
            }

            for (int j = 0; j < idchain; j++)
            {
                string w = wordchain[j];
                PlayMp3FromUrl(String.Format("https://translate.googleapis.com/translate_tts?ie=UTF-8&q={0}&tl={1}&total=1&idx=0&textlen={2}&client=gtx", HttpUtility.UrlEncode(w), language, w.Length));
            }

            if (mode == 2) button3.Text = "ĐỌC SỐ";
            else button3.Text = "READ";
        }
    }
}