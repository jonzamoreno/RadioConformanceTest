namespace RadioConformanceTests.Instruments;

public interface IBseInstrument
{
    bool IsDetected();
    void CellOn();
    void ConfigureCell(double freq, double power);
    void CellOff(); 
    bool UeConnected();
}
