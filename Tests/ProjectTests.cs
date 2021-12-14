

using HW5;
using HW5.GpuProducers;
using HW5.RamProducers;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private LenovoLaptop targetLenovoLaptop;
        private DellLaptop targetDellLaptop;
        private HpLaptop targetHpLaptop;
        private CorsairRam targetCorsair;
        private KingstonRam targetKingston;
        private SamsungRam targetSamsung;
        private AmdProcessor targetAmdProcessor;
        private IntelProcessor targetIntelProcessor;
        private AmdGpu targetAmdGpu;
        private NvidiaGpu targetNvidiaGpu;
        [SetUp]
        public void Setup()
        {
            targetLenovoLaptop = new LenovoLaptop();
            targetDellLaptop = new DellLaptop();
            targetHpLaptop = new HpLaptop();
            Laptop laptopRam1 = new TargetLaptop();
            Laptop laptopRam2 = new TargetLaptop();
            Laptop laptopRam3 = new TargetLaptop();
            Laptop laptopProcessor1 = new TargetLaptop();
            Laptop laptopProcessor2 = new TargetLaptop();
            Laptop latopGpu1 = new TargetLaptop();
            Laptop latopGpu2 = new TargetLaptop();
            targetCorsair = new CorsairRam(laptopRam1);
            targetKingston = new KingstonRam(laptopRam2);
            targetSamsung = new SamsungRam(laptopRam3);
            targetAmdProcessor = new AmdProcessor(laptopProcessor1);
            targetIntelProcessor = new IntelProcessor(laptopProcessor2);
            targetAmdGpu = new AmdGpu(latopGpu1);
            targetNvidiaGpu = new NvidiaGpu(latopGpu2);
        }

        [Test]
        public void TestLaptopProducerLenovo()
        {
            Laptop laptop = new LenovoLaptop();
            var targetPrice = targetLenovoLaptop.Price;
            var targetName = targetLenovoLaptop.ComponentName;
            Assert.AreEqual(laptop.Name, targetName);
            Assert.AreEqual(laptop.Cost, targetPrice);
        }
        [Test]
        public void TestLaptopProducerDell()
        {
            Laptop laptop = new DellLaptop();
            var targetPrice = targetDellLaptop.Price;
            var targetName = targetDellLaptop.ComponentName;
            Assert.AreEqual(laptop.Name, targetName);
            Assert.AreEqual(laptop.Cost, targetPrice);
        }
        [Test]
        public void TestLaptopProducerHp()
        {
            Laptop laptop = new HpLaptop();
            var targetPrice = targetHpLaptop.Price;
            var targetName = targetHpLaptop.ComponentName;
            Assert.AreEqual(laptop.Name, targetName);
            Assert.AreEqual(laptop.Cost, targetPrice);
        }
        [Test]
        public void TestGpuProducerAmd()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetAmdGpu.Price;
            var targetName = targetAmdGpu.Name;
            laptop = new AmdGpu(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestGpuProducerNvidia()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetNvidiaGpu.Price;
            var targetName = targetNvidiaGpu.Name;
            laptop = new NvidiaGpu(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestProcessorProducerAmd()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetAmdProcessor.Price;
            var targetName = targetAmdProcessor.Name;
            laptop = new AmdProcessor(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestProcessorProducerIntel()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetIntelProcessor.Price;
            var targetName = targetIntelProcessor.Name;
            laptop = new IntelProcessor(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestRamProducerCorsair()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetCorsair.Price;
            var targetName = targetCorsair.Name;
            laptop = new CorsairRam(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestRamProducerKingston()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetKingston.Price;
            var targetName = targetKingston.Name;
            laptop = new KingstonRam(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestRamProducerSamsung()
        {
            Laptop laptop = new TargetLaptop();
            var targetPrice = targetSamsung.Price;
            var targetName = targetSamsung.Name;
            laptop = new SamsungRam(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
            Assert.AreEqual(targetName, laptop.Name);
        }
        [Test]
        public void TestDellWithAmd()
        {
            Laptop laptop = new DellLaptop();
            var targetPrice = targetAmdProcessor.Price + targetAmdGpu.Price + targetDellLaptop.Cost;
            laptop = new AmdGpu(laptop);
            laptop = new AmdProcessor(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
        }
        [Test]
        public void TestLenovoWithIntelAndCorsair()
        {
            Laptop laptop = new LenovoLaptop();
            var targetPrice = targetIntelProcessor.Price + targetCorsair.Price + targetLenovoLaptop.Cost;
            laptop = new IntelProcessor(laptop);
            laptop = new CorsairRam(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
        }
        [Test]
        public void TestHpWithNvidiaAndSamsungAndIntel()
        {
            Laptop laptop = new HpLaptop();
            var targetPrice = targetIntelProcessor.Price + targetSamsung.Price + targetNvidiaGpu.Price + targetHpLaptop.Cost;
            laptop = new IntelProcessor(laptop);
            laptop = new SamsungRam(laptop);
            laptop = new NvidiaGpu(laptop);
            Assert.AreEqual(targetPrice, laptop.Cost);
        }

    }
    public class TargetLaptop : Laptop
    {
        public TargetLaptop()
        {
            Name = "";
            Cost = 0;
        }
    }

}