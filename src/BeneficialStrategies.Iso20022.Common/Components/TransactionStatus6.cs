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
/// Identifies the future status of the transaction by means of a code
/// </summary>
[IsoId("_w_JcYMX1EeiSF9q-coWegA")]
[DisplayName("Transaction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionStatus6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the status after comparing the exposure and the collateral required for the transaction.
    /// </summary>
    [IsoId("_JCKzsMX6EeiSF9q-coWegA")]
    [DisplayName("Coverage Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvrgSts")]
    #endif
    [IsoXmlTag("CvrgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralStatus1Code? CoverageStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralStatus1Code? CoverageStatus { get; init; } 
    #else
    public CollateralStatus1Code? CoverageStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is pending initiation or has been initiated.
    /// </summary>
    [IsoId("_P4TlEMX6EeiSF9q-coWegA")]
    [DisplayName("Execution Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnSts")]
    #endif
    [IsoXmlTag("ExctnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralStatus2Choice_? ExecutionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralStatus2Choice_? ExecutionStatus { get; init; } 
    #else
    public CollateralStatus2Choice_? ExecutionStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
