// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and its status to be updated in the tracker.
/// </summary>
[IsoId("_GcC_4XeKEfCdoODv2ypKfw")]
[DisplayName("Tracker Status And Transaction22")]
public record TrackerStatusAndTransaction22
{
    [IsoId("_GkWAQ3eKEfCdoODv2ypKfw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TrackerStatus1 TransactionStatus { get; init; }

    [IsoId("_GkWARXeKEfCdoODv2ypKfw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    [MinLength(1)]
    public ValueList<TrackerPaymentTransaction15> Transaction { get; init; } = [];
}
