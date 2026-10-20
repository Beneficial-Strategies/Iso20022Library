// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StructuredRemittanceInformation18ValidatorTests
{
    private readonly StructuredRemittanceInformation18Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IStructuredRemittanceInformation18>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IStructuredRemittanceInformation18>(b => b
            .Set(x => x.AdditionalRemittanceInformation).To(["Extra info"])
            .Set(x => x.CreditorReferenceInformation).To(IsoDataFactory.Make<ICreditorReferenceInformation3>())
            .Set(x => x.GarnishmentRemittance).To(IsoDataFactory.Make<IGarnishment4>(b2 => b2
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<IGarnishmentType1>(b3 => b3
                    .Set(x3 => x3.CodeOrProprietary).To(IsoDataFactory.Make<Choices.GarnishmentType1Choice.IProprietary>(b4 => b4
                        .Set(x4 => x4.Value).To("MYGARNISHMENT")))))))
            .Set(x => x.Invoicee).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Invoicee Co")))
            .Set(x => x.Invoicer).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Invoicer Co")))
            .Set(x => x.ReferredDocumentAmount).To(IsoDataFactory.Make<IRemittanceAmount4>())
            .Set(x => x.ReferredDocumentInformation).To([IsoDataFactory.Make<IReferredDocumentInformation8>()])
            .Set(x => x.TaxRemittance).To(IsoDataFactory.Make<ITaxData1>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
