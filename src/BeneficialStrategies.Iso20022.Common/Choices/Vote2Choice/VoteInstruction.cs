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
namespace BeneficialStrategies.Iso20022.Choices.Vote2Choice
{
    /// <summary>
    /// Instruction specifying the instructed quantity of voting rights per resolution. Split votes can be indicated. If only one type of decision is indicated, the number of votes cast must not be adjusted if the position of the voting party increases.
    /// </summary>
    [IsoId("_RDPjutp-Ed-ak6NoX_4Aeg_116941373")]
    [DisplayName("Vote Instruction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record VoteInstruction : Vote2Choice_
    #else
    public partial class VoteInstruction : Vote2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a VoteInstruction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public VoteInstruction( System.String reqIssuerLabel )
        {
            IssuerLabel = reqIssuerLabel;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Numbering of the resolution as specified by the issuer or its agent.
        /// </summary>
        [IsoId("_TK1iVNp-Ed-ak6NoX_4Aeg_62627585")]
        [DisplayName("Issuer Label")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IssrLabl")]
        #endif
        [IsoXmlTag("IssrLabl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text IssuerLabel { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String IssuerLabel { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IssuerLabel { get; init; } 
        #else
        public System.String IssuerLabel { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes in favour of one resolution.
        /// </summary>
        [IsoId("_TK1iVdp-Ed-ak6NoX_4Aeg_62627600")]
        [DisplayName("For")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="For")]
        #endif
        [IsoXmlTag("For")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? For { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? For { get; init; } 
        #else
        public System.UInt64? For { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes against one resolution.
        /// </summary>
        [IsoId("_TK1iVtp-Ed-ak6NoX_4Aeg_62627618")]
        [DisplayName("Against")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Agnst")]
        #endif
        [IsoXmlTag("Agnst")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Against { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Against { get; init; } 
        #else
        public System.UInt64? Against { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes expressed as abstain for one resolution.
        /// </summary>
        [IsoId("_TK_TUNp-Ed-ak6NoX_4Aeg_62627643")]
        [DisplayName("Abstain")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Abstn")]
        #endif
        [IsoXmlTag("Abstn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Abstain { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Abstain { get; init; } 
        #else
        public System.UInt64? Abstain { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes withheld for one resolution.
        /// </summary>
        [IsoId("_TK_TUdp-Ed-ak6NoX_4Aeg_62627660")]
        [DisplayName("Withhold")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Wthhld")]
        #endif
        [IsoXmlTag("Wthhld")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Withhold { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Withhold { get; init; } 
        #else
        public System.UInt64? Withhold { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes in line with the votes of the management.
        /// </summary>
        [IsoId("_TK_TUtp-Ed-ak6NoX_4Aeg_62627678")]
        [DisplayName("With Management")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="WthMgmt")]
        #endif
        [IsoXmlTag("WthMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? WithManagement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? WithManagement { get; init; } 
        #else
        public System.UInt64? WithManagement { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes against the voting recommendation of the management.
        /// </summary>
        [IsoId("_TK_TU9p-Ed-ak6NoX_4Aeg_62627937")]
        [DisplayName("Against Management")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AgnstMgmt")]
        #endif
        [IsoXmlTag("AgnstMgmt")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? AgainstManagement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? AgainstManagement { get; init; } 
        #else
        public System.UInt64? AgainstManagement { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes for which decision is left to the party that will exercise the voting right.
        /// </summary>
        [IsoId("_TK_TVNp-Ed-ak6NoX_4Aeg_62627955")]
        [DisplayName("Discretionary")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dscrtnry")]
        #endif
        [IsoXmlTag("Dscrtnry")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? Discretionary { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Discretionary { get; init; } 
        #else
        public System.UInt64? Discretionary { get; set; } 
        #endif
        
        /// <summary>
        /// Number of votes for which no action has been taken.
        /// </summary>
        [IsoId("_TK_TVdp-Ed-ak6NoX_4Aeg_128196007")]
        [DisplayName("No Action")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NoActn")]
        #endif
        [IsoXmlTag("NoActn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? NoAction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? NoAction { get; init; } 
        #else
        public System.UInt64? NoAction { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
