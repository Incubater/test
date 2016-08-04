using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace AwakeDream
{dasdasdsadasdas

    struct MixGroup
    {
        public List<int> lInList;
        public List<int> lOutList;
    }
    public class Mix
    {
        private static List<MixGroup> lMixGroupList;
        private static Mix _instance = null;

        private Mix()
        {

        }

        public static Mix getInstance()
        {
            if (_instance == null)
            {
                _instance = new Mix();
                lMixGroupList = new List<MixGroup>();
                _instance.InitMixGroup();
            }
            return _instance;
        }

        void InitMixGroup()
        {
            lMixGroupList.Add(new MixGroup { lInList = new List<int>() { 2, 5 }, lOutList = new List<int>() { 3 } });
            foreach (MixGroup mMix in lMixGroupList)
            {
                mMix.lInList.Sort();
            }
        }

        public List<int> CheckMix(List<int> lInList)
        {
            lInList.Sort();
            int n = -1;
            foreach (MixGroup mMix in lMixGroupList)
            {
                n++;
                if (mMix.lInList.Count != lInList.Count)
                    return null;
                for (int i = 0; i < mMix.lInList.Count; ++i)
                {
                    if (mMix.lInList[i] != lInList[i])
                    {
                        return null;
                    }
                }
            }
            return lMixGroupList[n].lOutList;
        }
    }
}
