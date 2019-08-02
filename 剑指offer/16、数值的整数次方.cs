public class solution
{
    public double Power(double num,int exponent)
    {
        if(num==0.0&&exponent<0)
        {
            throw new DivideByZeroException(); 
        }
        if(exponent==0)
        {
            return 1;
        }
        if(exponent==1)
        {
            return num;
        }

        if(exponent<0)
        {
            int absexponent=-exponent;
        }
        double result=PowWithUnsignedExponent(num,absexponent);
        if(exponent<0)
        {
            result=1.0/result;
        }
        return result;
    }
    private double PowWithUnsignedExponent(double num,int exponent)
    {
        if(exponent==0)
        {
            return 1;
        }
        if(exponent==1)
        {
            return num;
        }
        double result=PowWithUnsignedExponent(num,exponent>>1);
        result*=result;
        if(exponent&1)
        {
            result*=num;
        }

        return result;
    }
}