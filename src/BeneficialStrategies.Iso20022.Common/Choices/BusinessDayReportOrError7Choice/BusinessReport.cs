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
namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError7Choice
{
    /// <summary>
    /// Reports either business day information or a business error.
    /// </summary>
    [IsoId("_wq9RgZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessReport : BusinessDayReportOrError7Choice_
    #else
    public partial class BusinessReport : BusinessDayReportOrError7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a BusinessReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public BusinessReport( BusinessDayReportOrError8Choice_ reqBusinessDayOrError )
        {
            BusinessDayOrError = reqBusinessDayOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of a particular market infrastructure.
        /// </summary>
        [IsoId("_wy9-A5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("System Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SysId")]
        #endif
        [IsoXmlTag("SysId")]
        public ValueList<SystemIdentification2Choice_> SystemIdentification { get; init; } = new ValueList<SystemIdentification2Choice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _wy9-A5lcEeeE1Ya-LgRsuQ
        
        /// <summary>
        /// Requested information on the system availability for a specific business day or business error when information has not been found.
        /// </summary>
        [IsoId("_wy9-BZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Business Day Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BizDayOrErr")]
        #endif
        [IsoXmlTag("BizDayOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
        #else
        public BusinessDayReportOrError8Choice_ BusinessDayOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
