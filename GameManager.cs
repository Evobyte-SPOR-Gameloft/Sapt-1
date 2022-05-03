namespace Sapt1
{
    class GameManager
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        public void StartGame()
        {
            Console.WriteLine("Game started!");
        }
    }
}