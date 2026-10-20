// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Document15ValidatorTests
{
    private readonly Document15Validator _sut = new();

    private static Document15 ValidMessage() =>
        new()
        {
            Enclosure = Convert.ToBase64String([1, 2, 3]),
            Identification = "DOC-001",
            Format = new BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice.Code
            {
                Value = ExternalDocumentFormat1Code.PDF,
            },
            IssueDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            Type = new BeneficialStrategies.Iso20022.Choices.DocumentType1Choice.Code
            {
                Value = ExternalDocumentType1Code.CommercialInvoice,
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            DigitalSignature = new PartyAndSignature4
            {
                Party = new PartyIdentification272 { Name = "Signer Co" },
                Signature = new SkipPayload(),
            },
            FileName = "invoice.pdf",
            LanguageCode = "EN",
            Name = "Commercial Invoice",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
