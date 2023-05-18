public class ParkingSystem
{

    int _big = 0;
    int _medium = 0;
    int _little = 0;

    public ParkingSystem(int big, int medium, int small)
    {
        _big = big;
        _medium = medium;
        _little = small;
    }

    public bool AddCar(int carType)
    {
        if (carType == 1 && _big > 0)
        {
            _big--;
            return true;
        }

        if (carType == 2 && _medium > 0)
        {
            _medium--;
            return true;
        }

        if (carType == 3 && _little > 0)
        {
            _little--;
            return true;
        }

        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */