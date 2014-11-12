using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace LeagueOfLegendsTrivia
{
        public partial class QuestionPage : System.Web.UI.Page
        {
            string[] bank = new string[50];
            void fillbank()
            {
                bank[0] = "Question: What is Lux's full name?";
                bank[1] = "Answer: Luxanna 'Lux' Crownguard, Lady of Luminosity";

                bank[2] = "Question: When Jinx vandalized Vi's champion page on the League of Legends website, what was one of the things she wrote?";
                bank[3] = "Answer: 'Fat hands', 'Wussy Vest', 'Fail Train', 'Love Taps', 'Insufficient Force', 'Police Brutality', 'X Was Here'";

                bank[4] = "Audience Question: With Sivir's visual update, she has special taunts towards two champions.  Name one of them.";
                bank[5] = "Answer: Renekton or Cassiopeia";

                bank[6] = "Question: Which Noxian general did Garen slay?";
                bank[7] = "Answer: Urgot";

                bank[8] = "Question: Which Egyptian god was Nasus based off of?";
                bank[9] = "Answer: Anubis";

                bank[10] = "Audience Question: What is the name of Blitzcrank's dating service?";
                bank[11] = "Answer: Blitzcrank's Fleshling Compatibility Service";

                bank[12] = "Question: What is the name of the person whom had their soul stolen by Thresh that caused Lucian to become the Shadow Isle's worst enemy?";
                bank[13] = "Answer: Senna";

                bank[14] = "Question: Who is Lux's brother?";
                bank[15] = "Answer: Garen";

                bank[16] = "Question: Who was Garen paired with through Blitzcrank's dating service?";
                bank[17] = "Answer: Katarina";

                bank[18] = "Question: What does Jinx get her dance from?";
                bank[19] = "Answer: Jake from Adventure Time";

                bank[20] = "Audience Question: Who turned Warwick into a Lycan?";
                bank[21] = "Answer: Soraka";

                bank[22] = "Question: Which Riot designer created Nasus?";
                bank[23] = "Answer: Ezreal";

                bank[24] = "Question: How did Ahri turn into a human?";
                bank[25] = "Answer: A mage changed her into a human";

                bank[26] = "Audience Question: Who was the first champion to feature lyrics in their login screen?";
                bank[27] = "Answer: Diana";

                bank[28] = "Question: Who is Lux's enemy?";
                bank[29] = "Answer: Fiora";

                bank[30] = "Question: What is the nickname Garen earned very quickly after his release?";
                bank[31] = "Answer: The Merry-go-Round of Death";

                bank[32] = "Audience Question: Where did Lulu go when she lost track of time and returned to Bandle City unchanged?";
                bank[33] = "Answer: The Glades";

                bank[34] = "Question: What is Thresh's official title?";
                bank[35] = "Answer: The Chain Warden";

                bank[36] = "Question: Who is Nasus' brother?";
                bank[37] = "Answer: Renekton";

                bank[38] = "Audience Question: What is Leona's in-game hidden passive?";
                bank[39] = "Answer: Champions with sunglasses on in their current skin take 1 less damage";

                bank[40] = "Question: Which building did Jinx target to bring down as a direct challenge to Vi?";
                bank[41] = "Answer: The Piltover Treasury, said to be the most secure building in Piltover";

                bank[42] = "Question: What female K-Pop group inspired Ahri's Popstar skin?";
                bank[43] = "Answer: Girl's Generation";













                bank[44] = "Game Over!";
                bank[45] = "Tie Breakers!";
                bank[46] = "Question: According to a Reddit AMA, who does Jinx want to hug?";
                bank[47] = "Answer: Ziggs";
                bank[48] = "Question: Who was Lux seen with in Aatrox's preview?";
                bank[49] = "Answer: Ezreal";
            }
            protected void Page_Load(object sender, EventArgs e)
            {
                fillbank();
                if (!Page.IsPostBack)
                {
                    Label3.Text = "Welcome!";
                }
                else
                {
                    Button2.Visible = false;
                    int team1old = Convert.ToInt32(Button3.Text);
                    int team2old = Convert.ToInt32(Button4.Text);
                    Label3.Text = Convert.ToString(bank[Convert.ToInt32(Counter.Text)]);
                    Counter.Text = Convert.ToString(Convert.ToInt32(Counter.Text) + 1);
                }
            }

            protected void Button2_Click(object sender, EventArgs e)
            {           
                    
            }

            protected void Button3_Click(object sender, EventArgs e)
            {

            }

            protected void Button5_Click(object sender, EventArgs e)
            {
                if (Button5.CssClass == "threesightward")
                {
                    Button5.CssClass = "twosightward";
                }
                else if (Button5.CssClass == "twosightward")
                {
                    Button5.CssClass = "onesightward";
                }
                else
                {
                    Button5.Text = "NA";
                }
                Button3.Text = "       " + Convert.ToString(Convert.ToInt32(Button3.Text) + 25);
            }

            protected void Button7_Click(object sender, EventArgs e)
            {
                if (Button7.CssClass == "threesightward")
                {
                    Button7.CssClass = "twosightward";
                }
                else if (Button7.CssClass == "twosightward")
                {
                    Button7.CssClass = "onesightward";
                }
                else
                {
                    Button7.Text = "NA";
                }
                Button4.Text = "       " + Convert.ToString(Convert.ToInt32(Button4.Text) + 25);
            }

            protected void Button6_Click(object sender, EventArgs e)
            {
                Button6.Text = "NA";
                Button3.Text = "       " + Convert.ToString(Convert.ToInt32(Button3.Text) + 100);
            }

            protected void Button8_Click(object sender, EventArgs e)
            {
                Button8.Text = "NA";
                Button4.Text = "       " + Convert.ToString(Convert.ToInt32(Button4.Text) + 100);
            }

            protected void Button9_Click(object sender, EventArgs e)
            {
                Button3.Text = "       " + Convert.ToString(Convert.ToInt32(Button3.Text) + 150);
            }

            protected void Button10_Click(object sender, EventArgs e)
            {
                Button4.Text = "       " + Convert.ToString(Convert.ToInt32(Button4.Text) + 150);
            }

            protected void Button3_Click1(object sender, EventArgs e)
            {
                Button3.Text = "       " + Convert.ToString(Convert.ToInt32(Button3.Text) + 100);
            }

            protected void Button4_Click(object sender, EventArgs e)
            {
                Button4.Text = "       " + Convert.ToString(Convert.ToInt32(Button4.Text) + 100);
            }
        }
}