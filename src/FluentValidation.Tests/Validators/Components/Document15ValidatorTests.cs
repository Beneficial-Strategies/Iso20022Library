// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Document15ValidatorTests
{
    private readonly Document15Validator _sut = new();

    private static IDocument15 ValidMessage() =>
        IsoDataFactory.Make<IDocument15>(b => b
            .Set(x => x.Enclosure).To(Convert.ToBase64String([1, 2, 3]))
            .Set(x => x.Identification).To("DOC-001")
            .Set(x => x.Format).To(IsoDataFactory.Make<Choices.DocumentFormat1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalDocumentFormat1Code.PDF)))
            .Set(x => x.IssueDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.DocumentType1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalDocumentType1Code.CommercialInvoice))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DigitalSignature).To(IsoDataFactory.Make<IPartyAndSignature4>(b2 => b2
                .Set(x2 => x2.Party).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                    .Set(x3 => x3.Name).To("Signer Co")))
                .Set(x2 => x2.Signature).To(new SkipPayload())))
            .Set(x => x.FileName).To("invoice.pdf")
            .Set(x => x.LanguageCode).To("EN")
            .Set(x => x.Name).To("Commercial Invoice"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
