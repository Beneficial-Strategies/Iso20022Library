// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the refusal of a demand.
/// </summary>
[IsoId("_-FHEkHltEeG7BsjMvd1mEw_-1919643766")]
[DisplayName("Demand Refusal")]
public record DemandRefusal1
{
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-FHEkXltEeG7BsjMvd1mEw_1257238828")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-FHEknltEeG7BsjMvd1mEw_-400262050")]
    [DisplayName("Advising Party Reference Number")]
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the second advising party to the undertaking.
    /// </summary>
    [IsoId("_xcmwxRVREeKVqNjC36CBuQ")]
    [DisplayName("Second Advising Party Reference Number")]
    [IsoXmlTag("ScndAdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecondAdvisingPartyReferenceNumber { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-FHEk3ltEeG7BsjMvd1mEw_-671444297")]
    [DisplayName("Confirmer Reference Number")]
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; }

    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-FHElHltEeG7BsjMvd1mEw_866867684")]
    [DisplayName("Demand Details")]
    [IsoXmlTag("DmndDtls")]
    public required Demand2 DemandDetails { get; init; }

    /// <summary>
    /// Expicit indication of &apos;REFUSED&apos; as the processing status reported by the issuer.
    /// </summary>
    [IsoId("_-FHElXltEeG7BsjMvd1mEw_1035244109")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Refused7Text)]
    public required IsoRefused7Text Status { get; init; }

    /// <summary>
    /// Details related to the discrepancies.
    /// </summary>
    [IsoId("_-FQ1kHltEeG7BsjMvd1mEw_733408168")]
    [DisplayName("Discrepancy")]
    [IsoXmlTag("Dscrpncy")]
    public ValueList<Discrepancy1> Discrepancy { get; init; } = [];

    /// <summary>
    /// Indication of how the demand presentation documents will be handled as a consequence of the demand refusal.
    /// </summary>
    [IsoId("_-FQ1kXltEeG7BsjMvd1mEw_952637090")]
    [DisplayName("Disposition Of Documents")]
    [IsoXmlTag("DspstnOfDocs")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> DispositionOfDocuments { get; init; } = [];

    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_-FQ1knltEeG7BsjMvd1mEw_1467059748")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
