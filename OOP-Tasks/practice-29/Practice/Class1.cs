using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //internal abstract class Car
    //{
    //    public abstract void StartEngine();
    //    public abstract void StopEngine();
    //    public abstract void OpenDoor();
    //    public abstract void CloseDoor();
    //    public abstract void Honk();
    //    public abstract void IncreaseSpeed();
    //    public abstract void DecreaseSpeed();
    //    public abstract void Breaks();
    //    public abstract void OpenWindow();
    //    public abstract void CloseWindow();
    //    public abstract void AdjustSeat();
    //    public abstract void CleanGlass();
    //    public abstract void ChangeGear();
    //}

    //class Carfunctions : Car
    //{
    //    public override void StartEngine()
    //    {

    //    }
    //    public override void StopEngine() { }
    //    public override void OpenDoor() { }
    //    public override void CloseDoor() { }
    //    public override void Honk() { }
    //    public override void IncreaseSpeed() { }
    //    public override void DecreaseSpeed() { }

    //    public override void Breaks() { }
    //    public override void OpenWindow() { }
    //    public override void CloseWindow() { }
    //    public override void AdjustSeat() { }
    //   public override void ChangeGear() { }
    //    public override void CleanGlass()
    //    {

    //    }
    //}





     interface Car
    {
        void StartEngine();
        void StopEngine();
        void OpenDoor();
        void CloseDoor();
        void Honk();
        void IncreaseSpeed();
        void DecreaseSpeed();
        void Breaks();
        void OpenWindow();
        void CloseWindow();
        void AdjustSeat();
        void CleanGlass();
        void ChangeGear();
    }

     class Carfunctions : Car
    {
        public void StartEngine()
        {

        }
        public void StopEngine() { }
        public  void OpenDoor() { }
        public  void CloseDoor() { }
        public  void Honk() { }
        public  void IncreaseSpeed() { }
        public  void DecreaseSpeed() { }

        public  void Breaks() { }
        public  void OpenWindow() { }
        public  void CloseWindow() { }
        public  void AdjustSeat() { }
        public  void ChangeGear() { }
        public  void CleanGlass()
        {

        }
    }



}
