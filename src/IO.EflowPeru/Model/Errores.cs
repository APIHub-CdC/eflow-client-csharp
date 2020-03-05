using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.EflowPeru.Model
{
    [DataContract]
    public partial class Errores :  IEquatable<Errores>, IValidatableObject
    {
        public Errores(List<Error> errores = default(List<Error>))
        {
            this._Errores = errores;
        }
        [DataMember(Name="Errores", EmitDefaultValue=false)]
        public List<Error> _Errores { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Errores {\n");
            sb.Append("  _Errores: ").Append(_Errores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Errores);
        }
        public bool Equals(Errores input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Errores == input._Errores ||
                    this._Errores != null &&
                    this._Errores.SequenceEqual(input._Errores)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Errores != null)
                    hashCode = hashCode * 59 + this._Errores.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
