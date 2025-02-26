
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public int record = 0;
        public int coins = 70;
        public int numPicch = 0;

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            
        }
    }
}
