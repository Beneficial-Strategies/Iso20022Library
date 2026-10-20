// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

public class XmlValidationExtensionsTests
{
    private readonly IValidator<IMultilateralSettlementRequestV02> _sut = new MultilateralSettlementRequestV02Validator();

    private static MultilateralSettlementRequestV02 ValidMessage() =>
        new()
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "1",
            },
            SettlementRequest =
            [
                new MultilateralSettlementRequest3
                {
                    InstructionIdentification = "INSTR-001",
                    MovementRecord =
                    [
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } },
                            Identification = "MOV-001",
                        },
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 200m } },
                            Identification = "MOV-002",
                        },
                    ],
                },
            ],
        };

    private static XDocument ValidDocument() => Iso20022XmlSerializer.Serialize(ValidMessage());

    private static string Describe(ValidationResult result) =>
        string.Join("; ", result.Errors.Select(e => $"{e.ErrorCode} {e.PropertyName}: {e.ErrorMessage}"));

    [Fact]
    public void ValidXml_IsValid_AndReturnsTheRecord()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(xml, out MultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
        Assert.Equal("MSG-001", message!.GroupHeader.MessageIdentification.Value);
    }

    [Fact]
    public void Document_IsValid_AndReturnsTheRecord()
    {
        var result = _sut.Validate(ValidDocument(), out MultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
    }

    [Fact]
    public void ReadableXml_WithARuleViolation_ReturnsTheRuleFailures_AndTheRecord()
    {
        var invalid = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };
        var xml = Iso20022XmlSerializer.SerializeToString(invalid);

        var result = _sut.Validate(xml, out MultilateralSettlementRequestV02? message);

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");
        Assert.DoesNotContain(result.Errors, e => e.ErrorCode.StartsWith("Xml.", StringComparison.Ordinal));
        Assert.NotNull(message); // the record is returned whether or not the rules passed
    }

    [Fact]
    public void UnreadableXml_WithSeveralProblems_ReportsAllOfThem_AndNoRecord_AndRunsNoRules()
    {
        var document = ValidDocument();
        var ns = document.Root!.Name.Namespace;
        var message = document.Root.Elements().Single();
        message.Element(ns + "GrpHdr")!.Element(ns + "MsgId")!.Remove();                         // a required element missing
        message.Descendants(ns + "Amt").First().SetAttributeValue("Ccy", "euro");                // a bad value, deeper down
        message.Add(new XElement(ns + "NotInTheSpecification", "x"));                              // an element that does not belong

        var result = _sut.Validate(document, out MultilateralSettlementRequestV02? read);

        Assert.False(result.IsValid);
        Assert.Null(read);
        Assert.True(result.Errors.Count >= 2, Describe(result));
        Assert.All(result.Errors, e => Assert.StartsWith("Xml.", e.ErrorCode, StringComparison.Ordinal));
        Assert.All(result.Errors, e => Assert.IsType<DeserializationIssue>(e.CustomState));
        Assert.Contains(result.Errors, e => e.ErrorCode == "Xml." + IssueCode.RequiredMissing && e.PropertyName.Contains("MsgId"));
    }

    [Fact]
    public void MalformedXml_IsOneProblem_WithItsPosition()
    {
        var result = _sut.Validate("<Document><Unclosed>", out MultilateralSettlementRequestV02? message);

        Assert.Null(message);
        var failure = Assert.Single(result.Errors);
        Assert.Equal("Xml." + IssueCode.MalformedXml, failure.ErrorCode);
        Assert.NotNull(((DeserializationIssue)failure.CustomState).Line);
    }

    [Fact]
    public void WrongRoot_IsReported()
    {
        var result = _sut.Validate("<Other xmlns=\"urn:not-iso20022\"><Inner/></Other>", out MultilateralSettlementRequestV02? message);

        Assert.Null(message);
        Assert.Contains(result.Errors, e => e.ErrorCode == "Xml." + IssueCode.WrongRoot);
    }

    [Fact]
    public void NullXml_IsReportedAsAProblem_NotAnException()
    {
        var result = _sut.Validate((string)null!, out MultilateralSettlementRequestV02? message);

        Assert.Null(message);
        Assert.False(result.IsValid);
    }

    [Fact]
    public void Element_FromInsideALargerDocument_IsReadWithItsPathPrefix()
    {
        var document = ValidDocument();
        var ns = document.Root!.Name.Namespace;
        var header = document.Descendants(ns + "GrpHdr").Single();
        header.Element(ns + "MsgId")!.Remove();
        IValidator<IGroupHeader104> groupHeader = new GroupHeader104Validator();

        var result = groupHeader.Validate(header, out GroupHeader104? read, new ReadContext(ns, "Document/MltlatSttlmReq/"));

        Assert.Null(read);
        Assert.Contains(result.Errors, e => e.PropertyName.StartsWith("Document/MltlatSttlmReq/", StringComparison.Ordinal));
    }

    [Fact]
    public async Task Async_GivesTheSameResultAndTheRecord()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var (result, message) = await _sut.ValidateAsync<IMultilateralSettlementRequestV02, MultilateralSettlementRequestV02>(xml);
        var (bad, none) = await _sut.ValidateAsync<IMultilateralSettlementRequestV02, MultilateralSettlementRequestV02>("<x");

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
        Assert.False(bad.IsValid);
        Assert.Null(none);
    }

    [Fact]
    public void AValidatorOfTheRecordItself_Works_ThroughContravariance()
    {
        IValidator<MultilateralSettlementRequestV02> ofTheRecord = _sut; // IValidator<in T>
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = ofTheRecord.Validate(xml, out MultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
    }
}
