// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer order attached to a customer, recorded in the POI system.
/// </summary>
[IsoId("_R4AvQNuAEeiXqq0XHEoNUA")]
[DisplayName("Customer Order")]
public record CustomerOrder1
{
    /// <summary>
    /// Identification of a customer order.
    /// </summary>
    [IsoId("_Z4JOkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Customer Order Identification")]
    [IsoXmlTag("CstmrOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CustomerOrderIdentification { get; init; }

    /// <summary>
    /// Identification of a Sale transaction for a sequence of related POI transactions.
    /// </summary>
    [IsoId("_ewpOkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Specifies if a customer order is currently open.
    /// </summary>
    [IsoId("_pcoQINuAEeiXqq0XHEoNUA")]
    [DisplayName("Open Order State")]
    [IsoXmlTag("OpnOrdrStat")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OpenOrderState { get; init; }

    /// <summary>
    /// Date time of the beginning of an operation.
    /// </summary>
    [IsoId("_vD5aoNuAEeiXqq0XHEoNUA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime StartDate { get; init; }

    /// <summary>
    /// Date time of the end of an operation.
    /// </summary>
    [IsoId("_yyOtkNuAEeiXqq0XHEoNUA")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? EndDate { get; init; }

    /// <summary>
    /// Unit of amount.
    /// </summary>
    [IsoId("_3d_SENuAEeiXqq0XHEoNUA")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public AmountUnit1Code? Unit { get; init; }

    /// <summary>
    /// Initial or global amount of the order.
    /// </summary>
    [IsoId("_7BbjoNuAEeiXqq0XHEoNUA")]
    [DisplayName("Forecasted Amount")]
    [IsoXmlTag("FrcstdAmt")]
    public required ImpliedCurrencyAndAmount ForecastedAmount { get; init; }

    /// <summary>
    /// Total amount of all completed transactions of a customer order.
    /// </summary>
    [IsoId("__wALkNuAEeiXqq0XHEoNUA")]
    [DisplayName("Current Amount")]
    [IsoXmlTag("CurAmt")]
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; }

    /// <summary>
    /// Currency of monetary amount.
    /// </summary>
    [IsoId("_DvlmkNuBEeiXqq0XHEoNUA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Identification of an entity accessing data to perform an operation.
    /// </summary>
    [IsoId("_HYXEENuBEeiXqq0XHEoNUA")]
    [DisplayName("Accessed By")]
    [IsoXmlTag("AccsdBy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccessedBy { get; init; }

    /// <summary>
    /// Unqualified information related to customer order.
    /// </summary>
    [IsoId("_KkheENuBEeiXqq0XHEoNUA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
