// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the billing for services rendered on a temporary or contract basis. The component provides information such as the employee job performed, timekeeping, and billing rates.
/// </summary>
[IsoId("_QbcTNPfSEei89sMSHxl1ew")]
[DisplayName("Temporary Services")]
public record TemporaryServices1
{
    /// <summary>
    /// Contains the details of the contracting company that has requested temporary services.
    /// </summary>
    [IsoId("_QbcTOffSEei89sMSHxl1ew")]
    [DisplayName("Contracting Company")]
    [IsoXmlTag("CtrctgCpny")]
    public TemporaryServicesCompany1? ContractingCompany { get; init; }

    /// <summary>
    /// Contains information about the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_QbcTOvfSEei89sMSHxl1ew")]
    [DisplayName("Temporary Employee")]
    [IsoXmlTag("TempMplyee")]
    public PartyIdentification210? TemporaryEmployee { get; init; }

    /// <summary>
    /// Contains the details of the job or task of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_QbcTNvfSEei89sMSHxl1ew")]
    [DisplayName("Job")]
    [IsoXmlTag("Job")]
    public TemporaryServicesJob1? Job { get; init; }

    /// <summary>
    /// Indicates whether or not the fee for the individual working in a temporary capacity is a flat
    /// rate.
    /// </summary>
    [IsoId("_QbcTN_fSEei89sMSHxl1ew")]
    [DisplayName("Flat Rate Indicator")]
    [IsoXmlTag("FlatRateInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FlatRateIndicator { get; init; }

    /// <summary>
    /// Contains the discount amount.
    /// </summary>
    [IsoId("_e6IJUPfdEei89sMSHxl1ew")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_QbcTNffSEei89sMSHxl1ew")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains the details of the labour performed and associated duration and billing rate.
    /// </summary>
    [IsoId("_ns07wPfiEei89sMSHxl1ew")]
    [DisplayName("Labor")]
    [IsoXmlTag("Labr")]
    public TemporaryServicesLabor1? Labor { get; init; }

    /// <summary>
    /// Contains miscellaneous expense details.
    /// </summary>
    [IsoId("_bvgYsPfjEei89sMSHxl1ew")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public Amount13? MiscellaneousExpenses { get; init; }

    /// <summary>
    /// Subtotal amount exclusive of tax.
    /// </summary>
    [IsoId("_nG9ZIPfjEei89sMSHxl1ew")]
    [DisplayName("Subtotal Amount")]
    [IsoXmlTag("SbttlAmt")]
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; }

    /// <summary>
    /// Contains the amount of taxes assessed for temporary services.
    /// </summary>
    [IsoId("_1iAGYPfjEei89sMSHxl1ew")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax33? Tax { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the temporary services.
    /// </summary>
    [IsoId("_QbcTOPfSEei89sMSHxl1ew")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
