using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class PlayerScore
{
    public int Id;
    public string PlayerName;
    public int Score;
    public DateTime date; 
}

[Serializable]
public class PlayerScoreDomain {
    public List<PlayerScore> scoreList;

}