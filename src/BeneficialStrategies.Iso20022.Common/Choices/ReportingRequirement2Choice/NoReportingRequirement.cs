// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ReportingRequirement2Choice
{
    /// <summary>
    /// Specifies categories of statuses of a derivative when there is no reporting requirement for both counterparties.
    /// </summary>
    [IsoId("_IVUQM155Ee2a_-MvhEjKmA")]
    [DisplayName("No Reporting Requirement")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NoReportingRequirement : ReportingRequirement2Choice_
    #else
    public partial class NoReportingRequirement : ReportingRequirement2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NoReportingRequirement instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NoReportingRequirement( System.String reqRevived,System.String reqFurtherModification )
        {
            Revived = reqRevived;
            FurtherModification = reqFurtherModification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicator of derivative reopening, terminated or cancelled by mistake.
        /// </summary>
        [IsoId("_yfOdmT6CEe2Z1_pdMHu4SA")]
        [DisplayName("Revived")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rvvd")]
        #endif
        [IsoXmlTag("Rvvd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator Revived { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Revived { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Revived { get; init; } 
        #else
        public System.String Revived { get; set; } 
        #endif
        
        /// <summary>
        /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
        /// </summary>
        [IsoId("_yfOdmz6CEe2Z1_pdMHu4SA")]
        [DisplayName("Further Modification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrthrMod")]
        #endif
        [IsoXmlTag("FrthrMod")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoYesNoIndicator FurtherModification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String FurtherModification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String FurtherModification { get; init; } 
        #else
        public System.String FurtherModification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
