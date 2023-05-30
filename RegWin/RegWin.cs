namespace RegWin

{
    public static class CheckWin
    {
        public static int IsFinished(int[] krestiki_noliki)
        {
            for (int i = 0; i <= 6; i += 3)
            {
                if (krestiki_noliki[i] == krestiki_noliki[i + 1] && krestiki_noliki[i + 1] == krestiki_noliki[i + 2] && krestiki_noliki[i + 2] != 0)
                {
                    return krestiki_noliki[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (krestiki_noliki[i] == krestiki_noliki[i + 3] && krestiki_noliki[i + 3] == krestiki_noliki[i + 6] && krestiki_noliki[i + 6] != 0)
                {
                    return krestiki_noliki[i];
                }
            }
            if (krestiki_noliki[0] == krestiki_noliki[4] && krestiki_noliki[4] == krestiki_noliki[8] && krestiki_noliki[8] != 0)
            {
                return krestiki_noliki[0];
            }
            else if (krestiki_noliki[2] == krestiki_noliki[4] && krestiki_noliki[4] == krestiki_noliki[6] && krestiki_noliki[6] != 0)
            {
                return krestiki_noliki[2];
            }
            bool nichya = true;
            for (int i = 0; i < 9; i++)
            {
                if (krestiki_noliki[i] == 0)
                {
                    nichya = false;
                }
            }
            if (nichya == true) return 3;
            return 0;
        }
    }
}