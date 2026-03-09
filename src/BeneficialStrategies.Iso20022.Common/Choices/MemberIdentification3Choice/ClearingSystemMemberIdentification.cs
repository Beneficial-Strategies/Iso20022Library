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
namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification3Choice
{
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_iR9BhXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Clearing System Member Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ClearingSystemMemberIdentification : MemberIdentification3Choice_
    #else
    public partial class ClearingSystemMemberIdentification : MemberIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ClearingSystemMemberIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ClearingSystemMemberIdentification( System.String reqMemberIdentification )
        {
            MemberIdentification = reqMemberIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
        /// </summary>
        [IsoId("_TMehHdp-Ed-ak6NoX_4Aeg_-1082144614")]
        [DisplayName("Clearing System Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSysId")]
        #endif
        [IsoXmlTag("ClrSysId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; } 
        #else
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of a member of a clearing system.
        /// </summary>
        [IsoId("_TMehHtp-Ed-ak6NoX_4Aeg_151445420")]
        [DisplayName("Member Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MmbId")]
        #endif
        [IsoXmlTag("MmbId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text MemberIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String MemberIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String MemberIdentification { get; init; } 
        #else
        public System.String MemberIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
