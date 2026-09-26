// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalProspectusDocumentTypeCodeTests : ExternalCodesetContractTests<ExternalProspectusDocumentTypeCode>
{
    protected override string ValidSample => "AMND";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_Amendment_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalProspectusDocumentTypeCode.Amendment.Value);
    }

    [Fact]
    public void KnownValue_TranslationOfAppendix_HasExpectedWireCode()
    {
        Assert.Equal("APPT", ExternalProspectusDocumentTypeCode.TranslationOfAppendix.Value);
    }

    [Fact]
    public void KnownValue_BaseProspectusWithFinalTerm_HasExpectedWireCode()
    {
        Assert.Equal("BPFT", ExternalProspectusDocumentTypeCode.BaseProspectusWithFinalTerm.Value);
    }

    [Fact]
    public void KnownValue_BaseProspectusWithoutFinalTerm_HasExpectedWireCode()
    {
        Assert.Equal("BPWO", ExternalProspectusDocumentTypeCode.BaseProspectusWithoutFinalTerm.Value);
    }

    [Fact]
    public void KnownValue_CertificateOfApproval_HasExpectedWireCode()
    {
        Assert.Equal("COAP", ExternalProspectusDocumentTypeCode.CertificateOfApproval.Value);
    }

    [Fact]
    public void KnownValue_ExemptionDocument_HasExpectedWireCode()
    {
        Assert.Equal("EXMP", ExternalProspectusDocumentTypeCode.ExemptionDocument.Value);
    }

    [Fact]
    public void KnownValue_FinalOfferPrice_HasExpectedWireCode()
    {
        Assert.Equal("FOPA", ExternalProspectusDocumentTypeCode.FinalOfferPrice.Value);
    }

    [Fact]
    public void KnownValue_FinalTermsWithSummary_HasExpectedWireCode()
    {
        Assert.Equal("FTWS", ExternalProspectusDocumentTypeCode.FinalTermsWithSummary.Value);
    }

    [Fact]
    public void KnownValue_RegistrationDocument_HasExpectedWireCode()
    {
        Assert.Equal("REGN", ExternalProspectusDocumentTypeCode.RegistrationDocument.Value);
    }

    [Fact]
    public void KnownValue_SecuritiesNote_HasExpectedWireCode()
    {
        Assert.Equal("SECN", ExternalProspectusDocumentTypeCode.SecuritiesNote.Value);
    }

    [Fact]
    public void KnownValue_Summary_HasExpectedWireCode()
    {
        Assert.Equal("SMRY", ExternalProspectusDocumentTypeCode.Summary.Value);
    }

    [Fact]
    public void KnownValue_StandaloneProspectus_HasExpectedWireCode()
    {
        Assert.Equal("STDA", ExternalProspectusDocumentTypeCode.StandaloneProspectus.Value);
    }

    [Fact]
    public void KnownValue_TranslationOfSummary_HasExpectedWireCode()
    {
        Assert.Equal("SUMT", ExternalProspectusDocumentTypeCode.TranslationOfSummary.Value);
    }

    [Fact]
    public void KnownValue_Supplement_HasExpectedWireCode()
    {
        Assert.Equal("SUPP", ExternalProspectusDocumentTypeCode.Supplement.Value);
    }

    [Fact]
    public void KnownValue_UniversalRegistrationDocument_HasExpectedWireCode()
    {
        Assert.Equal("URGN", ExternalProspectusDocumentTypeCode.UniversalRegistrationDocument.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalProspectusDocumentTypeCode("AMND"), ExternalProspectusDocumentTypeCode.Amendment);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalProspectusDocumentTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
