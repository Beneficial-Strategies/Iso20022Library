// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("34d71dcc-2dae-40ae-839d-810a6c430ad9")]
[DisplayName("Fee12")]
public record Fee12
{
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("bfdadc3a-f458-4be1-98af-cc23080f84bb")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType10Choice? Type { get; init; }

    /// <summary>
    /// Modified value of the standard fee (charge/commission) amount applied on the order.
    /// </summary>
    [IsoId("53c823fb-6c75-4741-b44d-5c98a4aa45a5")]
    [DisplayName("Repaired Standard Amount")]
    [IsoXmlTag("RprdStdAmt")]
    public ActiveCurrencyAndAmount? RepairedStandardAmount { get; init; }

    /// <summary>
    /// Modified value of the standard fee (charge/commission) rate applied on the order.
    /// </summary>
    [IsoId("19414b64-5d11-479f-918e-fecdf13acc5a")]
    [DisplayName("Repaired Standard Rate")]
    [IsoXmlTag("RprdStdRate")]
    public IsoPercentageRate? RepairedStandardRate { get; init; }

    /// <summary>
    /// Modified value of the discount amount applied on the order.
    /// </summary>
    [IsoId("6b302881-d65d-44a4-abfd-b38f7a9868fa")]
    [DisplayName("Repaired Discount Amount")]
    [IsoXmlTag("RprdDscntAmt")]
    public ActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; }

    /// <summary>
    /// Modified value of the discount rate applied on the order.
    /// </summary>
    [IsoId("311b1045-c96e-4d4e-9dc6-8ed1bba59b85")]
    [DisplayName("Repaired Discount Rate")]
    [IsoXmlTag("RprdDscntRate")]
    public IsoPercentageRate? RepairedDiscountRate { get; init; }

    /// <summary>
    /// Modified value of the requested fee (charge/commission) amount applied on the order.
    /// </summary>
    [IsoId("9f919478-f271-4fa2-a1d5-0facf12a13a4")]
    [DisplayName("Repaired Requested Amount")]
    [IsoXmlTag("RprdReqdAmt")]
    public ActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; }

    /// <summary>
    /// Modified value of the requested fee (charge/commission) rate applied on the order.
    /// </summary>
    [IsoId("7dd5d494-bc9a-46c2-bd6d-093bbd44a4d6")]
    [DisplayName("Repaired Requested Rate")]
    [IsoXmlTag("RprdReqdRate")]
    public IsoPercentageRate? RepairedRequestedRate { get; init; }

    /// <summary>
    /// Reference to the agreement established between the fund and another party.
    /// </summary>
    [IsoId("8e76bd3d-4c75-4fd1-89ed-85aa3c1aa8d9")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    [IsoId("d5aac0c8-949b-4830-8169-b347e43aedb6")]
    [DisplayName("New Commercial Agreement Reference Indicator")]
    [IsoXmlTag("NewComrclAgrmtRefInd")]
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; }
}
