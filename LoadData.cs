using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System;
using System.IO;

namespace prj_HeartspingAdventure
{
    public class LoadData
    {
        public void Load(string LoadFileName)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string path = @"\Save";
            // PingStatus와 BossStatus 파일 이름을 조합
            string fileName1 = Path.Combine(directory + path, $"{LoadFileName}_PingStatus.json");
            string fileName2 = Path.Combine(directory + path, $"{LoadFileName}_BossStatus.json");

            try
            {
                // PingStatus 데이터 로드
                if (File.Exists(fileName1))
                {
                    string pingStatusJson = File.ReadAllText(fileName1);
                    JObject pingStatus = JObject.Parse(pingStatusJson);

                    // 로드된 값을 Status 클래스에 반영
                    Status.level = (int)pingStatus["level"];
                    Status.elegance = (int)pingStatus["elegance"];
                    Status.stress = (int)pingStatus["stress"];
                    Status.power_level = (int)pingStatus["power_level"];
                    Status.card_num = (int)pingStatus["card num"];

                    // card_flag 배열 로드
                    Status.card_flag = pingStatus["card flag"].ToObject<int[]>();  // int[] 형식으로 변환

                    Status.HP = (float)pingStatus["HP"];
                    Status.MaxHP = (float)pingStatus["MaxHP"];
                    Status.exp = (float)pingStatus["exp"];
                    Status.Maxexp = (float)pingStatus["Maxexp"];

                    // 스케줄 관련 데이터 추가 로드
                    Status.rest_count = (int)pingStatus["rest count"];
                    Status.snack_count = (int)pingStatus["snack count"];
                    Status.ballet_count = (int)pingStatus["ballet count"];
                    Status.dance_count = (int)pingStatus["dance count"];
                    Status.Max_rest_count = (int)pingStatus["Max rest count"];
                    Status.Max_snack_count = (int)pingStatus["Max snack count"];
                    Status.Max_ballet_count = (int)pingStatus["Max ballet count"];
                    Status.Max_dance_count = (int)pingStatus["Max dance count"];
                }
                else
                {
                    throw new FileNotFoundException("저장된 데이터를 불러올 수 없습니다.(character)");
                }

                // BossStatus 데이터 로드
                if (File.Exists(fileName2))
                {
                    string bossStatusJson = File.ReadAllText(fileName2);
                    Boss_Status Boss = new Boss_Status();

                    JObject bossStatus = JObject.Parse(bossStatusJson);

                    // 로드된 값을 Boss_Status 클래스에 반영
                    Boss.villan_power = (int)bossStatus["villan_power"];
                    Boss.villan_elegance = (int)bossStatus["villan_elegance"];
                }
                else
                {
                    throw new FileNotFoundException("저장된 데이터를 불러올 수 없습니다.(Boss)");
                }
            }
            catch (FileNotFoundException Loaderr)
            {
                MessageBox.Show(Loaderr.Message + "파일 로드 오류");
            }
            catch (Exception Loadex)
            {
                MessageBox.Show("저장된 데이터를 불러오는 중 오류가 발생하였습니다." + Loadex.Message);
            }
        }
    }
}