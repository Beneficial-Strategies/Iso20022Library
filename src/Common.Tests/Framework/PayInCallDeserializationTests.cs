// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

#pragma warning disable CS0612 // ReportData1 is obsolete in the ISO catalogue; camt.061 is built on it

using System.Xml.Linq;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Choices.PartyIdentification8Choice;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Pilot for issue #19 (deserialization reports every problem): camt.061.001.01, a small message
/// with a choice, an enum, an amount, a repeated element and required simple types.
/// </summary>
public class PayInCallDeserializationTests
{
    private const string Ns = "urn:iso:std:iso:20022:tech:xsd:camt.061.001.01";

    private static string Xml(
        string party = "<PtyId><BICOrBEI><BICOrBEI>DEUTDEFF</BICOrBEI></BICOrBEI></PtyId>",
        string msgId = "<MsgId>MSG-1</MsgId>",
        string valDt = "<ValDt>2026-01-02</ValDt>",
        string stamp = "<DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp>",
        string type = "<Tp>CFAV</Tp>",
        string amounts = "<PayInCallAmt><Amt Ccy=\"EUR\">10.50</Amt></PayInCallAmt><PayInCallAmt><Amt Ccy=\"EUR\">2.00</Amt></PayInCallAmt>",
        string extra = ""
    ) =>
        $"""
        <Document xmlns="{Ns}">
          <PayInCall>
            {party}
            <RptData>
              {msgId}
              {valDt}
              {stamp}
              {type}
              {amounts}
              {extra}
            </RptData>
          </PayInCall>
        </Document>
        """;

    private static IReadOnlyList<DeserializationIssue> Issues(string xml)
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(xml);
        Assert.False(result.Succeeded);
        Assert.Null(result.Message);
        return result.Issues;
    }

    [Fact]
    public void A_valid_document_is_read_in_full()
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml());

        Assert.True(result.Succeeded, string.Join("\n", result.Issues));
        Assert.Empty(result.Issues);
        var message = result.Message!;
        var party = Assert.IsType<BICOrBEI>(message.PartyIdentification);
        Assert.Equal("DEUTDEFF", (string)party.Value);
        Assert.Equal("MSG-1", (string)message.ReportData.MessageIdentification);
        Assert.Equal(CallIn1Code.CallForAccountValue, message.ReportData.Type);
        Assert.Equal(2, message.ReportData.PayInCallAmount.Count);
        Assert.Equal(10.50m, message.ReportData.PayInCallAmount[0].Amount.Amount);
        Assert.Equal("EUR", message.ReportData.PayInCallAmount[1].Amount.Currency);
    }

    [Fact]
    public void What_the_reader_accepts_the_serializer_wrote()
    {
        var first = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml()).Message!;
        var second = Iso20022XmlSerializer.TryRead<PayInCallV01>(Iso20022XmlSerializer.SerializeToString(first));

        Assert.True(second.Succeeded, string.Join("\n", second.Issues));
        Assert.Equal(first, second.Message);
    }

    /// <summary>
    /// The reason for #19. The first reader accepted a required element that is absent, because <c>required</c> is only a compiler
    /// rule and the record is built by reflection. <c>Deserialize</c> and <c>TryDeserialize</c> now read with <c>TryRead</c> (step 5).
    /// </summary>
    [Fact]
    public void Deserialize_and_TryDeserialize_reject_a_missing_required_element()
    {
        var ok = Iso20022XmlSerializer.TryDeserialize<PayInCallV01>(Xml(msgId: ""), out var message, out var error);

        Assert.False(ok);
        Assert.Null(message);
        var exception = Assert.IsType<Iso20022DeserializationException>(error);
        Assert.Equal("Document/PayInCall/RptData/MsgId", exception.Path);
        Assert.Equal(IssueCode.RequiredMissing, exception.First.Code);
        Assert.Throws<Iso20022DeserializationException>(() => Iso20022XmlSerializer.Deserialize<PayInCallV01>(Xml(msgId: "")));
    }

    [Fact]
    public void A_missing_required_element_is_reported_with_its_path()
    {
        var issue = Assert.Single(Issues(Xml(msgId: "")));

        Assert.Equal("Document/PayInCall/RptData/MsgId", issue.Path);
        Assert.Equal(IssueCode.RequiredMissing, issue.Code);
    }

    [Fact]
    public void Every_problem_is_reported_not_only_the_first()
    {
        var xml = Xml(
            party: "<PtyId><BICOrBEI></BICOrBEI></PtyId>",
            msgId: "",
            valDt: "<ValDt>2026-13-45</ValDt>",
            stamp: "<DtAndTmStmp>yesterday</DtAndTmStmp>",
            type: "<Tp>XXXX</Tp>",
            amounts: "<PayInCallAmt><Amt Ccy=\"EUR\">10.50</Amt></PayInCallAmt><PayInCallAmt><Amt>2.00</Amt></PayInCallAmt><PayInCallAmt><Amt Ccy=\"EUR\">lots</Amt></PayInCallAmt>",
            extra: "<Surprise>1</Surprise>"
        );

        var issues = Issues(xml);
        var byPath = issues.ToDictionary(i => i.Path);

        Assert.Equal(
            [
                "Document/PayInCall/PtyId/BICOrBEI/BICOrBEI",
                "Document/PayInCall/RptData/DtAndTmStmp",
                "Document/PayInCall/RptData/MsgId",
                "Document/PayInCall/RptData/PayInCallAmt[2]/Amt/@Ccy",
                "Document/PayInCall/RptData/PayInCallAmt[3]/Amt",
                "Document/PayInCall/RptData/Surprise",
                "Document/PayInCall/RptData/Tp",
                "Document/PayInCall/RptData/ValDt",
            ],
            byPath.Keys.Order()
        );
        Assert.Equal(IssueCode.RequiredMissing, byPath["Document/PayInCall/PtyId/BICOrBEI/BICOrBEI"].Code);
        Assert.Equal(IssueCode.RequiredMissing, byPath["Document/PayInCall/RptData/MsgId"].Code);
        Assert.Equal(IssueCode.RequiredMissing, byPath["Document/PayInCall/RptData/PayInCallAmt[2]/Amt/@Ccy"].Code);
        Assert.Equal(IssueCode.BadValue, byPath["Document/PayInCall/RptData/Tp"].Code);
        Assert.Equal(IssueCode.BadValue, byPath["Document/PayInCall/RptData/PayInCallAmt[3]/Amt"].Code);
        Assert.Equal(IssueCode.UnexpectedElement, byPath["Document/PayInCall/RptData/Surprise"].Code);
        Assert.Equal("XXXX", byPath["Document/PayInCall/RptData/Tp"].Value);
        Assert.Contains("CFAV", byPath["Document/PayInCall/RptData/Tp"].Reason); // lists what is valid
    }

    [Theory]
    [InlineData("-1")]
    [InlineData("0")]
    [InlineData("1")]
    public void An_enum_is_never_read_from_a_number(string text)
    {
        var issue = Assert.Single(Issues(Xml(type: $"<Tp>{text}</Tp>")));

        Assert.Equal("Document/PayInCall/RptData/Tp", issue.Path);
        Assert.Equal(IssueCode.BadValue, issue.Code);
    }

    [Fact]
    public void A_choice_with_no_variant_or_with_two_is_reported()
    {
        var none = Assert.Single(Issues(Xml(party: "<PtyId></PtyId>")));
        Assert.Equal(("Document/PayInCall/PtyId", IssueCode.UnknownChoice), (none.Path, none.Code));

        var two = Issues(Xml(party: "<PtyId><BICOrBEI><BICOrBEI>DEUTDEFF</BICOrBEI></BICOrBEI><NmAndAdr><Nm>A</Nm></NmAndAdr></PtyId>"));
        Assert.Contains(two, i => i.Path == "Document/PayInCall/PtyId" && i.Code == IssueCode.AmbiguousChoice);
    }

    [Fact]
    public void Issues_carry_the_line_of_the_element_they_are_about()
    {
        var issue = Assert.Single(Issues(Xml(type: "<Tp>XXXX</Tp>")));

        Assert.NotNull(issue.Line);
        Assert.True(issue.Line > 1);
    }

    [Fact]
    public void Malformed_xml_is_an_issue_not_an_exception()
    {
        var issue = Assert.Single(Issues("<Document><Unclosed>"));

        Assert.Equal(IssueCode.MalformedXml, issue.Code);
        Assert.NotNull(issue.Line);
    }

    [Fact]
    public void A_wrong_message_is_an_issue_not_an_exception()
    {
        var issue = Assert.Single(Issues("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:camt.061.001.01\"><Other/></Document>"));

        Assert.Equal(IssueCode.WrongRoot, issue.Code);
    }

    [Fact]
    public void A_part_is_read_from_inside_a_larger_document_with_its_namespace_inherited()
    {
        var document = XDocument.Parse(Xml(), LoadOptions.SetLineInfo);
        var rptData = document.Descendants(XName.Get("RptData", Ns)).Single();

        var result = Iso20022XmlSerializer.Read<ReportData1>(rptData, new ReadContext(PathPrefix: "Envelope/Body/"));

        Assert.True(result.Succeeded, string.Join("\n", result.Issues));
        Assert.Equal("MSG-1", (string)result.Message!.MessageIdentification);
    }

    [Fact]
    public void A_part_reports_issues_under_the_path_it_was_found_at()
    {
        var document = XDocument.Parse(Xml(msgId: ""), LoadOptions.SetLineInfo);
        var rptData = document.Descendants(XName.Get("RptData", Ns)).Single();

        var result = Iso20022XmlSerializer.Read<ReportData1>(rptData, new ReadContext(PathPrefix: "Envelope/Body/"));

        var issue = Assert.Single(result.Issues);
        Assert.Equal("Envelope/Body/RptData/MsgId", issue.Path);
    }

    [Fact]
    public void A_fragment_parsed_on_its_own_is_read_in_whatever_namespace_it_carries()
    {
        const string body = "<MsgId>M</MsgId><ValDt>2026-01-02</ValDt><DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp><Tp>CFAV</Tp>";

        var undeclared = Iso20022XmlSerializer.Read<ReportData1>(XElement.Parse($"<Whatever>{body}</Whatever>"));
        var declared = Iso20022XmlSerializer.Read<ReportData1>(XElement.Parse($"<Whatever xmlns=\"urn:caller:own\">{body}</Whatever>"));

        Assert.True(undeclared.Succeeded, string.Join("\n", undeclared.Issues));
        Assert.True(declared.Succeeded, string.Join("\n", declared.Issues));
    }

    [Fact]
    public void A_fragment_whose_own_element_is_in_another_namespace_says_which_one_its_children_are_in()
    {
        const string body = "<MsgId>M</MsgId><ValDt>2026-01-02</ValDt><DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp><Tp>CFAV</Tp>";
        var wrapper = XElement.Parse($"<j:Wrap xmlns:j=\"uri:jeff\" xmlns=\"{Ns}\">{body}</j:Wrap>");

        var guessed = Iso20022XmlSerializer.Read<ReportData1>(wrapper);
        var told = Iso20022XmlSerializer.Read<ReportData1>(wrapper, new ReadContext(Namespace: Ns));

        Assert.False(guessed.Succeeded);
        Assert.True(told.Succeeded, string.Join("\n", told.Issues));
    }
}
