// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalProspectusDocumentType1CodeTests : ExternalCodesetContractTests<ExternalProspectusDocumentType1Code>
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
        Assert.Equal("AMND", ExternalProspectusDocumentType1Code.Amendment.Value);
    }

    [Fact]
    public void KnownValue_TranslationOfAppendix_HasExpectedWireCode()
    {
        Assert.Equal("APPT", ExternalProspectusDocumentType1Code.TranslationOfAppendix.Value);
    }

    [Fact]
    public void KnownValue_BaseProspectusWithFinalTerm_HasExpectedWireCode()
    {
        Assert.Equal("BPFT", ExternalProspectusDocumentType1Code.BaseProspectusWithFinalTerm.Value);
    }

    [Fact]
    public void KnownValue_BaseProspectusWithoutFinalTerm_HasExpectedWireCode()
    {
        Assert.Equal("BPWO", ExternalProspectusDocumentType1Code.BaseProspectusWithoutFinalTerm.Value);
    }

    [Fact]
    public void KnownValue_CertificateOfApproval_HasExpectedWireCode()
    {
        Assert.Equal("COAP", ExternalProspectusDocumentType1Code.CertificateOfApproval.Value);
    }

    [Fact]
    public void KnownValue_ExemptionDocument_HasExpectedWireCode()
    {
        Assert.Equal("EXMP", ExternalProspectusDocumentType1Code.ExemptionDocument.Value);
    }

    [Fact]
    public void KnownValue_FinalOfferPrice_HasExpectedWireCode()
    {
        Assert.Equal("FOPA", ExternalProspectusDocumentType1Code.FinalOfferPrice.Value);
    }

    [Fact]
    public void KnownValue_FinalTermsWithSummary_HasExpectedWireCode()
    {
        Assert.Equal("FTWS", ExternalProspectusDocumentType1Code.FinalTermsWithSummary.Value);
    }

    [Fact]
    public void KnownValue_RegistrationDocument_HasExpectedWireCode()
    {
        Assert.Equal("REGN", ExternalProspectusDocumentType1Code.RegistrationDocument.Value);
    }

    [Fact]
    public void KnownValue_SecuritiesNote_HasExpectedWireCode()
    {
        Assert.Equal("SECN", ExternalProspectusDocumentType1Code.SecuritiesNote.Value);
    }

    [Fact]
    public void KnownValue_Summary_HasExpectedWireCode()
    {
        Assert.Equal("SMRY", ExternalProspectusDocumentType1Code.Summary.Value);
    }

    [Fact]
    public void KnownValue_StandaloneProspectus_HasExpectedWireCode()
    {
        Assert.Equal("STDA", ExternalProspectusDocumentType1Code.StandaloneProspectus.Value);
    }

    [Fact]
    public void KnownValue_TranslationOfSummary_HasExpectedWireCode()
    {
        Assert.Equal("SUMT", ExternalProspectusDocumentType1Code.TranslationOfSummary.Value);
    }

    [Fact]
    public void KnownValue_Supplement_HasExpectedWireCode()
    {
        Assert.Equal("SUPP", ExternalProspectusDocumentType1Code.Supplement.Value);
    }

    [Fact]
    public void KnownValue_UniversalRegistrationDocument_HasExpectedWireCode()
    {
        Assert.Equal("URGN", ExternalProspectusDocumentType1Code.UniversalRegistrationDocument.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalProspectusDocumentType1Code("AMND"), ExternalProspectusDocumentType1Code.Amendment);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalProspectusDocumentType1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
