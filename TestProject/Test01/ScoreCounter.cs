using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要： 点数データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            //点数データを格納する
            List<Student>  students= new List<Student>();
            //ファイルからすべてのデータを読み込む
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {//すべての行から一行ずつ取り出す
                string[] items = line.Split(',');//区切りで項目別に分ける
                Student score = new Student {//Studentインスタンスを生成

                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(score);//Studentインスタンスをコレクションに追加
            }
            return students;
        }

        //メソッドの概要： 科目別の点数を集計して結果を表示させる。
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;//科目が存在する
                else
                    dict[student.Subject] = student.Score;//科目が存在しない
            }
            return dict;




            
        }
    }
}
