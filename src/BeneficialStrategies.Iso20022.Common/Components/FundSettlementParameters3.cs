// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_QVV74tp-Ed-ak6NoX_4Aeg_1340706993")]
[DisplayName("Fund Settlement Parameters")]
public partial record FundSettlementParameters3
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_QVV749p-Ed-ak6NoX_4Aeg_1340707070")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Place where the settlement of transaction will take place. In the context of the investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_QVV75Np-Ed-ak6NoX_4Aeg_1340707019")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification2Choice_ SettlementPlace { get; init; } 
    
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_QVV75dp-Ed-ak6NoX_4Aeg_1340707028")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_QVV75tp-Ed-ak6NoX_4Aeg_1340707053")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVV759p-Ed-ak6NoX_4Aeg_1340707149")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public ReceivingPartiesAndAccount3? ReceivingSideDetails { get; init; } 
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVV76Np-Ed-ak6NoX_4Aeg_1340707120")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public required DeliveringPartiesAndAccount3 DeliveringSideDetails { get; init; } 
    
    
    #nullable disable
    
}
