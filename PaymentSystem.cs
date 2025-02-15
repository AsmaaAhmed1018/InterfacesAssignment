namespace InterfacesAssignment
{
    internal class PaymentSystem
    {
        IPayment[] objs = new IPayment[10];

        public void AddObj(IPayment obj)
        {
        }

        public void Start()
        {
            for (int i = 0; i < objs.Length; i++)
            {
                objs[i].Payment();
            }
        }
    }
}
