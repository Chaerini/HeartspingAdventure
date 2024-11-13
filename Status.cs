using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prj_HeartspingAdventure
{
    public class Status
    {
        // 스탯
        public static int level { get; set; }               // 레벨
        public static int elegance { get; set; }            // 품위
        public static int stress { get; set; }              // 스트레스
        public static int power_level { get; set; }         // 전투력
        public static int card_num { get; set; }            // 카드개수  
        public static float HP { get; set; }                // 현재 체력
        public static float MaxHP { get; set; }             // 최대 체력
        public static float exp { get; set; }               // 경험치
        public static float Maxexp { get; set; }            // 최대 경험치
        public static int[] card_flag = new int[10];        // 카드 플래그 (필요시 수정)

        // 스케쥴
        public static int rest_count { get; set; }        // 휴식
        public static int Max_rest_count { get; set; }      // 최대 휴식횟수
        public static int snack_count { get; set; }         // 간식
        public static int Max_snack_count { get; set; }     // 최대 간식횟수
        public static int ballet_count { get; set; }        // 발레
        public static int Max_ballet_count { get; set; }    // 최대 발레횟수
        public static int dance_count { get; set; }         // 춤
        public static int Max_dance_count { get; set; }     // 최대 춤 횟수

        public Status() // 생성자
        {

        }

        public static void levelUP() // 레벨업 메서드
        {
            if (exp == Maxexp) // 레벨업 조건   
            {
                level += 1;    // 레벨 +1
                MaxHP += 50;   // 최대 체력 +50
                HP = MaxHP;    // 현재 체력 회복
                Maxexp += 100; // 최대경험치 100 증가
                exp = 0;       // 경험치 0으로 초기화
                //Max_ballet_count++;
                //Max_dance_count++;
                //Max_rest_count++;
                //Max_snack_count++;
            }
        }

        public static void StatusInit() // 스탯 초기화 -> 다음날이 되면 초기화~
        {
            HP = MaxHP;          // 체력 회복
            stress = stress / 2; // 스트레스 -50% 
        }

        public static void FirstStatus() // 스탯 초기값
        {
            level = 1;
            elegance = 10;
            stress = 0;
            MaxHP = 100;
            HP = MaxHP;
            exp = 0;
            Maxexp = 100;
            card_num = 0;
            power_level = 10;

            Max_ballet_count = 2;
            Max_dance_count = 2;
            Max_rest_count = 3;
            Max_snack_count = 1;

            // 사용하면 0에서 ++ 되야됨
            // 최대 횟수에 맞물리면 더 기능 동작 안하게 만들어야됨
            ballet_count = 0;
            dance_count = 0;
            rest_count = 0;
            snack_count = 0;
        }
    }
    // 보스 스탯
    class Boss_Status : Status
    {

        public int villan_power { get; set; }
        public int villan_elegance { get; set; }
    }

}
