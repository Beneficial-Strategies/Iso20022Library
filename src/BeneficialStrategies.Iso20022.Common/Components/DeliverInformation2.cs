// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_VMxk59p-Ed-ak6NoX_4Aeg_-1013586045")]
[DisplayName("Deliver Information")]
public record DeliverInformation2
{
    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_VMxk6Np-Ed-ak6NoX_4Aeg_-214525296")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge4? ChargeDetails { get; init; }

    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_VMxk6dp-Ed-ak6NoX_4Aeg_534530656")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax3? TaxDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_VMxk6tp-Ed-ak6NoX_4Aeg_-889025934")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public required DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VMxk69p-Ed-ak6NoX_4Aeg_-1109217545")]
    [DisplayName("Physical Transfer Indicator")]
    [IsoXmlTag("PhysTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_VM7V4Np-Ed-ak6NoX_4Aeg_-816993140")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters2? PhysicalTransferDetails { get; init; }
}
