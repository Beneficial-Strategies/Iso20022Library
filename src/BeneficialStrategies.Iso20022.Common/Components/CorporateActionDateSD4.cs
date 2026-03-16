// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
[IsoId("_1ePnUzL3EeKU9IrkkToqcw_1659480407")]
[DisplayName("Corporate Action Date SD")]
public record CorporateActionDateSD4
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ePnVDL3EeKU9IrkkToqcw_662408054")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Date on which accounting for due bills starts and associated tracking begins.
    /// </summary>
    [IsoId("_1ePnVTL3EeKU9IrkkToqcw_-568372746")]
    [DisplayName("Interim Accounting Start Date")]
    [IsoXmlTag("IntrmAcctgStartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterimAccountingStartDate { get; init; }

    /// <summary>
    /// Date on which the event security is no longer listed on the exchange.
    /// </summary>
    [IsoId("_1ePnVjL3EeKU9IrkkToqcw_-868959552")]
    [DisplayName("Delisting Date")]
    [IsoXmlTag("DlistgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DelistingDate { get; init; }

    /// <summary>
    /// Date by which a holder can exercise warrants.
    /// </summary>
    [IsoId("_1eZYUDL3EeKU9IrkkToqcw_608195982")]
    [DisplayName("Exercise Period Begin Date")]
    [IsoXmlTag("ExrcPrdBegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExercisePeriodBeginDate { get; init; }

    /// <summary>
    /// Date by which a holder listed as a member of the claimant group in a lawsuit may object to the proposed solution.
    /// </summary>
    [IsoId("_1eZYUTL3EeKU9IrkkToqcw_757336184")]
    [DisplayName("Objection Date")]
    [IsoXmlTag("ObjctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ObjectionDate { get; init; }

    /// <summary>
    /// Date by which claimants may exclude themselves from an ongoing class action lawsuit.
    /// </summary>
    [IsoId("_1eZYUjL3EeKU9IrkkToqcw_526220081")]
    [DisplayName("Exclusion Date")]
    [IsoXmlTag("ExclsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExclusionDate { get; init; }

    /// <summary>
    /// Date by which a holder must file claim forms to become a member of the claimant group in a lawsuit.
    /// </summary>
    [IsoId("_1eZYUzL3EeKU9IrkkToqcw_338802594")]
    [DisplayName("Proof Of Claim Filing Date")]
    [IsoXmlTag("ProofOfClmFilgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProofOfClaimFilingDate { get; init; }
}
