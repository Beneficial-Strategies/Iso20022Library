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
/// Information about the new account.
/// </summary>
[IsoId("_a8noUdcZEeqRFcf2R4bPBw")]
[DisplayName("New Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NewAccount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NewAccount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NewAccount3( CashAccount41 reqAccount )
    {
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the new account.
    /// </summary>
    [IsoId("_a99FEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount41 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount41 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount41 Account { get; init; } 
    #else
    public CashAccount41 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    [IsoId("_a99FE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPty")]
    #endif
    [IsoXmlTag("AcctPty")]
    public ValueList<IndividualPerson36> AccountParty { get; init; } = new ValueList<IndividualPerson36>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _a99FE9cZEeqRFcf2R4bPBw
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_a99FFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Org")]
    #endif
    [IsoXmlTag("Org")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation35? Organisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation35? Organisation { get; init; } 
    #else
    public Organisation35? Organisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
