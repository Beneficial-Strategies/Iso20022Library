// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the securities index request operations for national competent authorities.
/// </summary>
[IsoId("_00E_kL3kEeWvRsMSLyTf-A")]
[DisplayName("Securities Index Report")]
public record SecuritiesIndexReport1
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and feedback messages.
    /// Usage:
    /// This identification will be used in the status advice sent back.
    /// </summary>
    [IsoId("_M8By8b7VEeW_FPJ0tzugkw")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Country code of the entity that wishes to express an interest in receiving transaction reports for the requested indexes.
    /// </summary>
    [IsoId("_K91sAL3lEeWvRsMSLyTf-A")]
    [DisplayName("Requesting Entity")]
    [IsoXmlTag("RqstngNtty")]
    public CountryCode? RequestingEntity { get; init; }

    /// <summary>
    /// Details the index that is being requested.
    /// </summary>
    [IsoId("_5eLhwL3lEeWvRsMSLyTf-A")]
    [DisplayName("Index")]
    [IsoXmlTag("Indx")]
    public required FinancialInstrument46Choice_ Index { get; init; }

    /// <summary>
    /// Date when the national competent authority last expressed its interest in this index.
    /// </summary>
    [IsoId("_mAsbEr31EeWvRsMSLyTf-A")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public Period4Choice_? ValidityPeriod { get; init; }
}
