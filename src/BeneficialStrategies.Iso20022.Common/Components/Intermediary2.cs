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
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
[IsoId("_QP-6ydp-Ed-ak6NoX_4Aeg_-172074213")]
[DisplayName("Intermediary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Intermediary2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Intermediary2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Intermediary2( PartyIdentification10Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QP-6ytp-Ed-ak6NoX_4Aeg_-285913279")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification10Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification10Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_ Identification { get; init; } 
    #else
    public PartyIdentification10Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_QP-6y9p-Ed-ak6NoX_4Aeg_588690940")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Role2Choice_? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Role2Choice_? Role { get; init; } 
    #else
    public Role2Choice_? Role { get; set; } 
    #endif
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QP-6zNp-Ed-ak6NoX_4Aeg_-408381413")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account9? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account9? Account { get; init; } 
    #else
    public Account9? Account { get; set; } 
    #endif
    
    
    #nullable disable
    
}
