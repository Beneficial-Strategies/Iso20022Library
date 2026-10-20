// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Factory;

public class IsoBuilderTests
{
    [Fact]
    public void Make_SetsTheNamedMembers_AndConvertsTheValuesAsARecordWould()
    {
        var id = IsoDataFactory.Make<IGenericIdentification3>(b => b
            .Set(x => x.Identification).To("ID-1")
            .Set(x => x.Issuer).To("BANK"));

        Assert.Equal("ID-1", id.Identification.Value);
        Assert.Equal("BANK", id.Issuer!.Value.Value);
    }

    [Fact]
    public void AMemberThatIsNotNamed_StaysUnset_AndAListIsEmpty()
    {
        var id = IsoDataFactory.Make<IGenericIdentification3>(b => b.Set(x => x.Identification).To("ID-1"));
        var request = IsoDataFactory.Make<IMultilateralSettlementRequest3>();

        Assert.Null(id.Issuer);
        Assert.Empty(request.MovementRecord);
    }

    [Fact]
    public void ObjectsNestAndAListTakesItsItems()
    {
        var request = IsoDataFactory.Make<IMultilateralSettlementRequest3>(b => b
            .Set(x => x.InstructionIdentification).To("INSTR-1")
            .Set(x => x.MovementRecord).To([
                IsoDataFactory.Make<IMovementRecord2>(m => m.Set(x => x.Identification).To("MOV-1")),
                IsoDataFactory.Make<IMovementRecord2>(m => m.Set(x => x.Identification).To("MOV-2")),
            ]));

        Assert.Equal(["MOV-1", "MOV-2"], request.MovementRecord.Select(r => r.Identification.Value));
    }

    [Fact]
    public void TwoObjectsWithTheSameMembers_AreEqual()
    {
        IGenericIdentification3 Make() => IsoDataFactory.Make<IGenericIdentification3>(b => b.Set(x => x.Identification).To("ID-1"));

        Assert.Equal(Make(), Make());
        Assert.NotSame(Make(), Make());
    }

    [Fact]
    public void AnExpressionThatNamesNoMember_IsRefused()
    {
        var ex = Assert.Throws<ArgumentException>(() =>
            IsoDataFactory.Make<IGenericIdentification3>(b => b.Set(x => x.Identification.Value.Length.ToString()).To("x")));

        Assert.Contains("member", ex.Message);
    }

    [Fact]
    public void ASetThatIsNeverCompleted_ChangesNothing()
    {
        var id = IsoDataFactory.Make<IGenericIdentification3>(b => { _ = b.Set(x => x.Issuer); });

        Assert.Null(id.Issuer);
    }
}
