using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    public class Day
    {
        public int dayNum;
        public Color dayColor;
        public GameObject obj; //this refers to each of the days in the calander week. Each one of those days is a day obj.

        public Day(int dayNum, Color dayColor, GameObject obj)
        {
            this.dayNum = dayNum; // day of the month that each day represents
            this.dayColor = dayColor;
            this.obj = obj;
            UpdateColor(dayColor);
            UpdateDay(dayNum);
        }

        //This is called when you are updating the color so that the dayColor is update & the visiual color on the screen is updated.
        public void UpdateColor(Color newColor)
        {
            obj.GetComponent<Image>().color = newColor;
            dayColor = newColor;
        }

        public void UpdateDay(int newDayNum)
        {
            this.dayNum = newDayNum;
            if (dayColor == Color.white || dayColor == Color.green)
            {
                obj.GetComponentInChildren<Text>().text = (dayNum + 1).ToString();
            }
            else
            {
                obj.GetComponentInChildren<Text>().text = ""; //this refers to disabled days. 
            }
        }
    }
 
    private List<Day> days = new List<Day>(); // this is all of the days of the month. The days are stored here so that we don't have to recreate them every time.
                                              // This way we only have to create them once and then can update them.
                                              // This way we only have to update everything about the days but don't need to create new day objects.

        public Transform[] weeks;

        public Text MonthAndYear;

        public DateTime currDate = DateTime.Now;



        private void Start()
        {
            UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);
        }


        void UpdateCalendar(int year, int month)
        {
            DateTime temp = new DateTime(year, month, 1);
            currDate = temp;
            MonthAndYear.text = temp.ToString("MMMM") + " " + temp.Year.ToString();
            int startDay = GetMonthStartDay(year, month);
            int endDay = GetTotalNumberOfDays(year, month);


            if(days.Count == 0)
            {
                for(int w = 0; w < 6; w++)
                {
                    for(int i = 0; i < 7; i++)
                    {
                        Day newDay;
                        int currDay = (w*7) +i;
                        if (currDay < startDay || currDay - startDay >= endDay)
                        {
                            newDay = new Day(currDay - startDay, Color.grey, weeks[w].GetChild(i).gameObject);
                        }
                        else
                        {
                            newDay = new Day(currDay - startDay, Color.white, weeks[w].GetChild(i).gameObject);
                        }
                        days.Add(newDay);
                    }
                }
            }
            else
            {
                for(int i = 0; i < 42; i++)
                {
                    if(i < startDay || i - startDay >= endDay)
                    {
                        days[i].UpdateColor(Color.grey);
                    }
                    else
                    {
                        days[i].UpdateColor(Color.white);
                    }
                    days[i].UpdateDay(i - startDay);
                }
            }


            if(DateTime.Now.Year == year && DateTime.Now.Month == month)
            {
                days[(DateTime.Now.Day - 1) + startDay].UpdateColor(Color.green);
            }
        }


        int GetMonthStartDay(int year, int month)
        {
            DateTime temp = new DateTime(year, month, 1);

            return (int)temp.DayOfWeek;
        }

        int GetTotalNumberOfDays(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public void SwitchMonth(int direction)
        {
            if(direction < 0)
            {
                currDate = currDate.AddMonths(-1);
            }
            else
            {
                currDate = currDate.AddMonths(1);
            }
            UpdateCalendar(currDate.Year, currDate.Month);
    }
}

/*
 *     [Serializable]
    public class Day
    {
        public List<GameObject> days = new List<GameObject>(); // this is all of the days of the month objects
        public int dayNum;
        public Color dayColor;
    }

    public List<Day> weeks = new List<Day>();
    void Start()
    {
        foreach (var item in weeks)
        {
            foreach (var day in item.days)
            {
                day.transform.GetChild(0).GetComponent<Text>().text = "";
            }
        }
        LoadDate(DateTime.Today.Year, DateTime.Today.Month);
    }


    int GetNumberofDays(int year, int month)
    {
        return DateTime.DaysInMonth(year, month);
    }

    int GetMonthStartDay(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);
        return (int)temp.DayOfWeek;
    }

    public void LoadDate(int year, int month)
    {
        int endDay = GetNumberofDays(year, month);
        int startDay = GetMonthStartDay(year, month);
        int rowCounter = 0;
        for (int day = 1; day <= endDay; day++)
        {
            weeks[rowCounter].days[startDay].transform.GetChild(0).GetComponent<Text>().text = day.ToString();
            startDay++;
            if (startDay % 7 == 0)
            {
                rowCounter++;
                startDay = 0;
            }
        }

    }
}
 */
