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
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError3Choice
{
    /// <summary>
    /// Provides the details on the requested member.
    /// </summary>
    [IsoId("_i0a-UZlCEee-Zps0fZQaFQ")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : MemberReportOrError3Choice_
    #else
    public partial class Report : MemberReportOrError3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( MemberIdentification2Choice_ reqMemberIdentification,MemberReportOrError4Choice_ reqMemberOrError )
        {
            MemberIdentification = reqMemberIdentification;
            MemberOrError = reqMemberOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
        /// </summary>
        [IsoId("_i8mp8ZlCEee-Zps0fZQaFQ")]
        [DisplayName("Member Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MmbId")]
        #endif
        [IsoXmlTag("MmbId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required MemberIdentification2Choice_ MemberIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required MemberIdentification2Choice_ MemberIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberIdentification2Choice_ MemberIdentification { get; init; } 
        #else
        public MemberIdentification2Choice_ MemberIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Reports either on a member or a business error.
        /// </summary>
        [IsoId("_i8mp85lCEee-Zps0fZQaFQ")]
        [DisplayName("Member Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MmbOrErr")]
        #endif
        [IsoXmlTag("MmbOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required MemberReportOrError4Choice_ MemberOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required MemberReportOrError4Choice_ MemberOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberReportOrError4Choice_ MemberOrError { get; init; } 
        #else
        public MemberReportOrError4Choice_ MemberOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
