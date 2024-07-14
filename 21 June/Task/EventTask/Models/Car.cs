using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTask.Models
{
    public delegate void SpeedEventsHandler(int vites, Color color);

    public class Vehicle
    {
        public event SpeedEventsHandler SpeedEvents;
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool Start { get; set; }
        private int _speed;
        public int Hiz 
        {
            get => _speed;
            
            set 
            {
                _speed = value;
                if (_speed > 1) 
                {
                    switch (_speed)
                    {
                        case int s when (s < 50): 
                            {
                                SpeedEvents(1, Color.FromArgb(21, 245, 186));
                                break; 
                            }
                        case int s when (s < 70): 
                            {
                                SpeedEvents(1, Color.FromArgb(160, 204, 10));

                                break; 
                            }
                        case int s when (s < 100): 
                            {
                                SpeedEvents(1, Color.FromArgb(179, 176, 10));
                                break; }
                        case int s when (s < 100): 
                            {
                                SpeedEvents(1, Color.FromArgb(236, 92, 2));
                                break; }
                        case int s when (s < 170): 
                            {
                                SpeedEvents(1, Color.FromArgb(255, 64, 0));
                                break; 
                            }
                              
                    }
                }
            } 
        }
    }
}
