// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the collateral agreement.
/// </summary>
[IsoId("_Ar7UOAM2EeutW5-TpeYJhA")]
[DisplayName("Obligation")]
public record Obligation7
{
    /// <summary>
    /// One of the entities associated with the collateral agreement
    /// </summary>
    [IsoId("_Ar7UPgM2EeutW5-TpeYJhA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification178Choice_ PartyA { get; init; }

    /// <summary>
    /// Party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    [IsoId("_Ar7UPAM2EeutW5-TpeYJhA")]
    [DisplayName("Servicing Party A")]
    [IsoXmlTag("SvcgPtyA")]
    public PartyIdentification178Choice_? ServicingPartyA { get; init; }

    /// <summary>
    /// Other entity associated with the collateral agreement
    /// </summary>
    [IsoId("_Ar7UOgM2EeutW5-TpeYJhA")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification178Choice_ PartyB { get; init; }

    /// <summary>
    /// Party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    [IsoId("_Ar7UPwM2EeutW5-TpeYJhA")]
    [DisplayName("Servicing Party B")]
    [IsoXmlTag("SvcgPtyB")]
    public PartyIdentification178Choice_? ServicingPartyB { get; init; }

    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_Ar7UOQM2EeutW5-TpeYJhA")]
    [DisplayName("Collateral Account Identification")]
    [IsoXmlTag("CollAcctId")]
    public CollateralAccount3? CollateralAccountIdentification { get; init; }

    /// <summary>
    /// Underlying business area or type of trade causing the collateral movement.
    /// </summary>
    [IsoId("_Ar7UPQM2EeutW5-TpeYJhA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public ExposureType5Code? ExposureType { get; init; }

    /// <summary>
    /// Type of collateral instruction.
    /// </summary>
    [IsoId("_6nB9EQM2EeutW5-TpeYJhA")]
    [DisplayName("Collateral Transaction Type")]
    [IsoXmlTag("CollTxTp")]
    public CollateralTransactionType1Choice_? CollateralTransactionType { get; init; }

    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_-7dmsQM2EeutW5-TpeYJhA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public CollateralRole1Code? CollateralSide { get; init; }

    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_Vd_YcQM3EeutW5-TpeYJhA")]
    [DisplayName("Exposure Amount")]
    [IsoXmlTag("XpsrAmt")]
    public AmountAndDirection20? ExposureAmount { get; init; }

    /// <summary>
    /// Close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    [IsoId("_Ar7UOwM2EeutW5-TpeYJhA")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    public DateAndDateTime2Choice_? ValuationDate { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_eAL4cQM2EeutW5-TpeYJhA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public ClosingDate4Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_jdq00QM2EeutW5-TpeYJhA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }
}
