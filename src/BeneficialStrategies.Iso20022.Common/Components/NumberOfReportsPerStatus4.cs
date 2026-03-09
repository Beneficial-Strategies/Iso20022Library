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
/// Number of reports per status.
/// </summary>
[IsoId("_6MfxgXA0EeuQQPLl0vKpYw")]
[DisplayName("Number Of Reports Per Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfReportsPerStatus4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfReportsPerStatus4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfReportsPerStatus4( System.String reqDetailedNumberOfReports,PairedReconciled3Code reqDetailedStatus )
    {
        DetailedNumberOfReports = reqDetailedNumberOfReports;
        DetailedStatus = reqDetailedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual reports sent / received, detailed per status.
    /// </summary>
    [IsoId("_6PNuUXA0EeuQQPLl0vKpYw")]
    [DisplayName("Detailed Number Of Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldNbOfRpts")]
    #endif
    [IsoXmlTag("DtldNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumberOfReports { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DetailedNumberOfReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumberOfReports { get; init; } 
    #else
    public System.String DetailedNumberOfReports { get; set; } 
    #endif
    
    /// <summary>
    /// Common report status for all individual reports sent / received.
    /// </summary>
    [IsoId("_6PNuU3A0EeuQQPLl0vKpYw")]
    [DisplayName("Detailed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldSts")]
    #endif
    [IsoXmlTag("DtldSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PairedReconciled3Code DetailedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PairedReconciled3Code DetailedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PairedReconciled3Code DetailedStatus { get; init; } 
    #else
    public PairedReconciled3Code DetailedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
