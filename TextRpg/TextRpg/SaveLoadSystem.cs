using Newtonsoft.Json;


namespace TextRpg
{
    public class SaveLoadSystem
    {
        //게임 데이터가 저장될 파일 경로를 지정
        private static string filePath = "gameData.json";

        //데이터 저장용 메서드
        //저장을 위해선 ? GameData를 해당 메서드에 전달해줘야 그 내용을 저장할 수 있음
        public static void SaveGame(GameData data)
        {
            // 데이터를 JSON형식으로 직렬화 하는 코드
            //Formatting.Indented 이부분은 들여쓰기를 적용하는 "옵션"
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            //위에서 직렬화 한 JSON데이터를 파일로 저장
            File.WriteAllText(filePath, json);
            // 출력 및 슬립을 줘서 사용자가 저장중인것을 인지시킴
            Console.WriteLine("진행상황을 저장중입니다...");
            Thread.Sleep(3000);
        }

        //데이터 불러오기용 메서드
        public static GameData LoadGame()
        {
            //데이터 파일이 있는지 확인하고
            if (File.Exists(filePath))
            {
                //JSON데이터를 문자열로 변환
                string json = File.ReadAllText(filePath);
                //JSON형식의 문자열을 GameData객체로 변환해주는 코드 (압축과 압축풀기로 이해하면 매우 쉬움)
                GameData data = JsonConvert.DeserializeObject<GameData>(json);
                Console.WriteLine("진행상황을 불러오는 중입니다...");
                Thread.Sleep(3000);
                //불러온 변환한 데이터를 반환해서 게임내에 반영
                return data;
            }
            else
            {
                Console.WriteLine("불러올 파일이 없습니다.");
                Thread.Sleep(3000);
                return null;
            }
        }
    }
}
