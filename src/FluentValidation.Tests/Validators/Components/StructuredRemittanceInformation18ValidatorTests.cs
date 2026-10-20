// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StructuredRemittanceInformation18ValidatorTests
{
    private readonly StructuredRemittanceInformation18Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new StructuredRemittanceInformation18()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new StructuredRemittanceInformation18
        {
            AdditionalRemittanceInformation = ["Extra info"],
            CreditorReferenceInformation = new CreditorReferenceInformation3(),
            GarnishmentRemittance = new Garnishment4
            {
                Type = new GarnishmentType1
                {
                    CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice.Proprietary
                    {
                        Value = "MYGARNISHMENT",
                    },
                },
            },
            Invoicee = new PartyIdentification272 { Name = "Invoicee Co" },
            Invoicer = new PartyIdentification272 { Name = "Invoicer Co" },
            ReferredDocumentAmount = new RemittanceAmount4(),
            ReferredDocumentInformation = [new ReferredDocumentInformation8()],
            TaxRemittance = new TaxData1(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
