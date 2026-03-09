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
/// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
/// </summary>
[IsoId("_KYvvc4uZEeKYr_965Eh8aQ")]
[DisplayName("Clearing Broker Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingBrokerIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingBrokerIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingBrokerIdentification1( SideIndicator1Code reqSideIndicator,System.String reqClearingBrokerIdentification )
    {
        SideIndicator = reqSideIndicator;
        ClearingBrokerIdentification = reqClearingBrokerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Distinguishes the client leg from the central counterparty (CCP) leg in the clearing broker identification.
    /// </summary>
    [IsoId("_s1IrIIuZEeKYr_965Eh8aQ")]
    [DisplayName("Side Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdInd")]
    #endif
    [IsoXmlTag("SdInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SideIndicator1Code SideIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SideIndicator1Code SideIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SideIndicator1Code SideIndicator { get; init; } 
    #else
    public SideIndicator1Code SideIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification assigned to the clearing broker.
    /// </summary>
    [IsoId("_1RBSUIuZEeKYr_965Eh8aQ")]
    [DisplayName("Clearing Broker Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBrkrId")]
    #endif
    [IsoXmlTag("ClrBrkrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ClearingBrokerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClearingBrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClearingBrokerIdentification { get; init; } 
    #else
    public System.String ClearingBrokerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
