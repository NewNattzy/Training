namespace GameObjectGenerator
{

    public static class QuestGenerator
    {

        private static Dictionary<string, string> ActiveQuests = new Dictionary<string, string>();
        private static Dictionary<string, string> CompleteQuests = new Dictionary<string, string>();

        public static Dictionary<string, string> ActiveQuest
        {
            get
            {
                return ActiveQuests;
            }
            set
            {
                object Quest = value;
                ActiveQuests.Add("Quest.NPC", "Quest.Name");
            }
        }

        // TODO: Помещать завершенные квесты в словарь вида "NPC":"QuestName" используя объект Quest (?)
        public static Dictionary<string, string> CompliteQuest
        {
            get
            {
                return CompleteQuests;
            }
            set
            {
                object Quest = value;
                CompleteQuests.Add("Quest.NPC", "Quest.Name");
            }
        }

    }

}
