using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace prj_HeartspingAdventure
{
    public class SaveData
    {
        public void Save(string saveFileName)
        {
            // 저장 경로 -> 필요시 수정
            string directory = System.IO.Directory.GetCurrentDirectory(); // 현재 실행되는 파일 위치 "현재 실행파일\\bin\Debug\net6.0-windows" 기준
            string path = @"\Save";

            // 디렉터리가 없으면 생성
            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }

            try
            {
                // Json 파일에 들어갈 내용들(하츄핑 스탯)
                JObject PingStatus = new JObject
                (
                    new JProperty("level", Status.level),                          // 레벨
                    new JProperty("elegance", Status.elegance),                    // 품위
                    new JProperty("stress", Status.stress),                        // 스트레스
                    new JProperty("power_level", Status.power_level),              // 전투력                
                    new JProperty("card num", Status.card_num),                    // 최대카드개수
                    new JProperty("card flag", Status.card_flag),                  // 카드 플래그
                    new JProperty("HP", Status.HP),                                // 현재 체력
                    new JProperty("MaxHP", Status.MaxHP),                          // 최대 체력
                    new JProperty("exp", Status.exp),                              // 현재 경험치
                    new JProperty("Maxexp", Status.Maxexp),                        // 최대 경험치

                    // 스케쥴 횟수
                    new JProperty("rest count", Status.rest_count),                // 휴식
                    new JProperty("snack count", Status.snack_count),              // 간식
                    new JProperty("ballet count", Status.ballet_count),            // 발레
                    new JProperty("dance count", Status.dance_count),              // 춤
                    new JProperty("Max rest count", Status.Max_rest_count),        // 최대 휴식횟수
                    new JProperty("Max snack count", Status.Max_snack_count),      // 최대 간식횟수
                    new JProperty("Max ballet count", Status.Max_ballet_count),    // 최대 발레횟수
                    new JProperty("Max dance count", Status.Max_dance_count)       // 최대 춤 횟수
                );

                // Json 파일에 들어갈 내용들(보스 스탯)
                Boss_Status Boss = new Boss_Status();
                JObject BossStatus = new JObject
                (
                    new JProperty("villan_power", Boss.villan_power),
                    new JProperty("villan_elegance", Boss.villan_elegance)
                );

                // 파일 이름 구분 (PingStatus, BossStatus를 구분해서 저장)
                string fileName1 = Path.Combine(directory + path, $"{saveFileName}_PingStatus.json");
                string fileName2 = Path.Combine(directory + path, $"{saveFileName}_BossStatus.json");

                // 파일 쓰기
                File.WriteAllText(fileName1, PingStatus.ToString());
                File.WriteAllText(fileName2, BossStatus.ToString());
            }
            catch (Exception Saveex)
            {
                MessageBox.Show("저장에 실패했습니다." + Saveex.Message);
            }
        }

    }
}
