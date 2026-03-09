// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the pledge and pledger.
/// </summary>
[IsoId("_xiaQoPQ9EeqAradXpAelDQ")]
[DisplayName("Pledge Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PledgeInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PledgeInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PledgeInformation1( PartyIdentification232Choice_ reqPledger,GenericIdentification36 reqPledgeType )
    {
        Pledger = reqPledger;
        PledgeType = reqPledgeType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity that provide assets to a counterparty as a guarantee.
    /// </summary>
    [IsoId("_C2xUYPQ-EeqAradXpAelDQ")]
    [DisplayName("Pledger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pldgr")]
    #endif
    [IsoXmlTag("Pldgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification232Choice_ Pledger { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification232Choice_ Pledger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232Choice_ Pledger { get; init; } 
    #else
    public PartyIdentification232Choice_ Pledger { get; set; } 
    #endif
    
    /// <summary>
    /// Third party, usually a bank, involved in the pledge.
    /// </summary>
    [IsoId("_FfoNAPQ-EeqAradXpAelDQ")]
    [DisplayName("Third Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPty")]
    #endif
    [IsoXmlTag("ThrdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThirdPartyIdentification1? ThirdParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThirdPartyIdentification1? ThirdParty { get; init; } 
    #else
    public ThirdPartyIdentification1? ThirdParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of pledge.
    /// </summary>
    [IsoId("_KBvGQPQ-EeqAradXpAelDQ")]
    [DisplayName("Pledge Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PldgTp")]
    #endif
    [IsoXmlTag("PldgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification36 PledgeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification36 PledgeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36 PledgeType { get; init; } 
    #else
    public GenericIdentification36 PledgeType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pledger is entitled to vote, otherwise the right to vote is with the right holder.
    /// </summary>
    [IsoId("_Q7cJAPQ-EeqAradXpAelDQ")]
    [DisplayName("Return Securities Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrSctiesInd")]
    #endif
    [IsoXmlTag("RtrSctiesInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ReturnSecuritiesIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReturnSecuritiesIndicator { get; init; } 
    #else
    public System.String? ReturnSecuritiesIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
