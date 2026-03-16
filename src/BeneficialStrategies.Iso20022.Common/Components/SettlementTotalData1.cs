// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of settlement instructions.
/// </summary>
[IsoId("_oVUHMI0TEemUAO64Q252gQ")]
[DisplayName("Settlement Total Data")]
public record SettlementTotalData1
{
    /// <summary>
    /// Aggregated volume and value of settlement instructions settled during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_oVUHM40TEemUAO64Q252gQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public required SettlementDataVolume2 Settled { get; init; }

    /// <summary>
    /// Aggregated volume and value of settlement instructions failed during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_oVUHNI0TEemUAO64Q252gQ")]
    [DisplayName("Failed")]
    [IsoXmlTag("Faild")]
    public required SettlementDataVolume2 Failed { get; init; }

    /// <summary>
    /// Aggregated total volume and value of settlement instructions performed (settled and failed) during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_oVUHMY0TEemUAO64Q252gQ")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public required SettlementDataVolume2 Total { get; init; }

    /// <summary>
    /// Rate of failed settlement instructions compared to the total volume and value, of settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_oVUHMo0TEemUAO64Q252gQ")]
    [DisplayName("Failed Rate")]
    [IsoXmlTag("FaildRate")]
    public required SettlementDataRate2 FailedRate { get; init; }
}
