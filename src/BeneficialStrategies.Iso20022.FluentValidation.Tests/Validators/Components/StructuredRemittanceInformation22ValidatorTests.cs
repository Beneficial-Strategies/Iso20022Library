// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StructuredRemittanceInformation22ValidatorTests
{
    private readonly StructuredRemittanceInformation22Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new StructuredRemittanceInformation22()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new StructuredRemittanceInformation22
        {
            ReferredDocumentInformation = [new ReferredDocumentInformation8()],
            ReferredDocumentAmount = new RemittanceAmount4(),
            CreditorReferenceInformation = new CreditorReferenceInformation3(),
            Invoicer = new PartyIdentification272 { Name = "Invoicer Co" },
            Invoicee = new PartyIdentification272 { Name = "Invoicee Co" },
            TaxRemittance = new TaxData1(),
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
            SecuritiesData = [new SecuritiesAttributes1 { UniqueTransactionIdentifier = "ABCDEFGHIJKLMNOPQR12" }],
            AdditionalRemittanceInformation = ["Extra info"],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
