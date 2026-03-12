// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
[IsoId("_QVV76dp-Ed-ak6NoX_4Aeg_1594715500")]
[DisplayName("Fund Settlement Parameters")]
public partial record FundSettlementParameters4
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_QVfs4Np-Ed-ak6NoX_4Aeg_1594715795")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Place where the settlement of transaction will take place. In the context of the investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_QVfs4dp-Ed-ak6NoX_4Aeg_1594715519")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification2Choice_ SettlementPlace { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    [IsoId("_QVfs4tp-Ed-ak6NoX_4Aeg_1594715535")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_QVfs49p-Ed-ak6NoX_4Aeg_1594715553")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVfs5Np-Ed-ak6NoX_4Aeg_1594715842")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public required ReceivingPartiesAndAccount3 ReceivingSideDetails { get; init; } 
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVfs5dp-Ed-ak6NoX_4Aeg_1594715873")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public DeliveringPartiesAndAccount3? DeliveringSideDetails { get; init; } 
    
    
    #nullable disable
    
}
