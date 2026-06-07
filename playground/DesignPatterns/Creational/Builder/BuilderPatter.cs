namespace DesignPatterns.Creational.Builder;

public class Computer
{
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
    public bool HasGPU { get; set; }

    public override string ToString()
    {
        return $"Computer [CPU={CPU}, RAM={RAM}, Storage={Storage}, GPU={HasGPU}]";
    }

    // Initially private constructor to enforce object creation through the builder
    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
        HasGPU = builder.HasGPU;
    }

    public Computer(string cpu, int ram, int storage, bool hasGpu)
    {
        CPU = cpu;
        RAM = ram;
        Storage = storage;
        HasGPU = hasGpu;
    }


    public class Builder
    {
        public string CPU { get; private set; } = string.Empty;
        public int RAM { get; private set; }
        public int Storage { get; private set; }
        public bool HasGPU { get; private set; }

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(int ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(int storage)
        {
            Storage = storage;
            return this;
        }

        public Builder SetGPU(bool hasGPU)
        {
            HasGPU = hasGPU;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}
