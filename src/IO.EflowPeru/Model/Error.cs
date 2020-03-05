using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.EflowPeru.Model
{
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        public Error(string codigo = default(string), string mensaje = default(string))
        {
            this.Codigo = codigo;
            this.Mensaje = mensaje;
        }
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
        [DataMember(Name="mensaje", EmitDefaultValue=false)]
        public string Mensaje { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  Mensaje: ").Append(Mensaje).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Error);
        }
        public bool Equals(Error input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Codigo == input.Codigo ||
                    (this.Codigo != null &&
                    this.Codigo.Equals(input.Codigo))
                ) && 
                (
                    this.Mensaje == input.Mensaje ||
                    (this.Mensaje != null &&
                    this.Mensaje.Equals(input.Mensaje))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Codigo != null)
                    hashCode = hashCode * 59 + this.Codigo.GetHashCode();
                if (this.Mensaje != null)
                    hashCode = hashCode * 59 + this.Mensaje.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
