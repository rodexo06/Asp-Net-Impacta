using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExercicioManiImg.DAL;
//using ExercicioManiImg.Models;

namespace ExercicioManiImg
{
    public partial class FuncionarioWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AtualizarGrid();
                AtualizarDropDownFuncionarios();
            }
        }

        private void AtualizarDropDownFuncionarios()
        {
            string selecionado = reportarParaDropDownList
             .SelectedValue;
            reportarParaDropDownList.DataTextField = "Nome";
            reportarParaDropDownList.DataValueField = "funcionarioId";

            var db = new FuncionarioDb();
            var query = from c in db.FuncionarioListaDinamica()
                        select new
                        {
                            c.FuncionarioID,
                            Nome = c.Nome + " " + c.SobreNome
                        };
            reportarParaDropDownList.DataSource = query.ToList();
            reportarParaDropDownList.DataBind();

            if (!string.IsNullOrEmpty(selecionado))
            {
                reportarParaDropDownList.SelectedValue = selecionado;
            }
        }

        private void AtualizarGrid()
        {
            var db = new FuncionarioDb();
            var query = from c in db.FuncionarioListaDinamica()
                        select new
                        {
                            c.FuncionarioID,
                            Nome = c.Nome + " " + c.SobreNome,
                            c.Cargo,
                            c.Endereco,
                            c.Cidade,
                            c.Estado,
                            c.Pais,
                            Telefone = c.TelefoneResidencial,
                            c.FotoPath
                        };
            funcionariosGridView.DataSource = query.ToList();
            funcionariosGridView.DataBind();
        }

        private void LimparForm()
        {
            ViewState["funcionarioId"] = 0;
            nomeTextBox.Text = string.Empty;
            sobrenomeTextBox.Text = string.Empty;
            cargoTextBox.Text = string.Empty;
            dataAdmissaoTextBox.Text = string.Empty;
            dataNascimentoTextBox.Text = string.Empty;
            enderecoTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            cepTextBox.Text = string.Empty;
            paisTextBox.Text = string.Empty;
            telefoneResidencialTextBox.Text = string.Empty;
            ramalTextBox.Text = string.Empty;
            tratamentoTextBox.Text = string.Empty;
            observacoesTextBox.Text = string.Empty;
            fotoUrlImage.ImageUrl = "~/ imagens / funcionarios / semFoto.png";
        }
        protected void novoButton_Click(object sender, EventArgs e)
        {
            LimparForm();
            formMultiView.ActiveViewIndex = 1;

            incluirButton.Visible = true;
            AlterarButton.Visible = false;
            ExcluirButton.Visible = false;
        }

        private Funcionario ObterFuncionario()
        {
            var funcionario = new Funcionario();
            funcionario.FuncionarioID =
             (int)ViewState["funcionarioId"];
            funcionario.Nome = nomeTextBox.Text;
            funcionario.SobreNome = sobrenomeTextBox.Text;
            funcionario.Cargo = cargoTextBox.Text;
            funcionario.CEP = cepTextBox.Text;
            funcionario.Cidade = cidadeTextBox.Text;
            funcionario.TelefoneResidencial = telefoneResidencialTextBox.Text;
            funcionario.Tratamento = tratamentoTextBox.Text;

            if (!string.IsNullOrEmpty(dataAdmissaoTextBox.Text))
            {
                funcionario.DataAdmissao =
               Convert.ToDateTime(dataAdmissaoTextBox.Text);
            }
            else
            { funcionario.DataAdmissao = null; }
            if (!string.IsNullOrEmpty(dataNascimentoTextBox.Text))
            {
                funcionario.DataNascimento =
                Convert.ToDateTime(dataNascimentoTextBox.Text);
            }
            else
            { funcionario.DataNascimento = null; }
            funcionario.Endereco = enderecoTextBox.Text;
            funcionario.Estado = estadoTextBox.Text;
            funcionario.Observacoes = observacoesTextBox.Text;
            funcionario.Pais = paisTextBox.Text;
            funcionario.Ramal = ramalTextBox.Text;
            funcionario.ReportarPara = Convert.ToInt32(reportarParaDropDownList.SelectedValue);
            ObterFoto(funcionario);
            return funcionario;
        }

        private void ObterFoto(Funcionario funcionario)
        {
            if (fotoUrlFileUpload.HasFile)
            {
                funcionario.Foto = fotoUrlFileUpload.FileBytes;
            }
        }

        private void Mensagem(string msg)
        {
            mensagemLabel.Text = msg;
            mensagemLabel.Visible = !string.IsNullOrEmpty(msg);
        }

        void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var funcionario = ObterFuncionario();
                var db = new FuncionarioDb();
                AtualizarGrid();
                Mensagem("Funcionário incluido com sucesso");
                incluirButton.Visible = false;
                ExcluirButton.Visible = false;
            }
            catch (Exception ex)
            {
                Mensagem(ex.Message);
            }

        }

        private void ExibirFuncionario(int id)
        {
            Mensagem(null);
            var db = new FuncionarioDb();
            var funcionario = db.FuncionarioPorId(id);
            if (funcionario == null)
            {
                Mensagem("Funcionário não encontrado");
                return;
            }

            formMultiView.ActiveViewIndex = 1;
            ViewState["funcionarioId"] = id;
            nomeTextBox.Text = funcionario.Nome;
            sobrenomeTextBox.Text = funcionario.SobreNome;
            cargoTextBox.Text = funcionario.Cargo;
            dataAdmissaoTextBox.Text = string.Format("{0:d}",funcionario.DataAdmissao);
            dataNascimentoTextBox.Text = string.Format("{0:d}",funcionario.DataNascimento);
            enderecoTextBox.Text = funcionario.Endereco;
            cidadeTextBox.Text = funcionario.Cidade;
            estadoTextBox.Text = funcionario.Estado;
            cepTextBox.Text = funcionario.CEP;
            paisTextBox.Text = funcionario.Pais;
            telefoneResidencialTextBox.Text =
            funcionario.TelefoneResidencial;
            ramalTextBox.Text = funcionario.Ramal;
            tratamentoTextBox.Text = funcionario.Tratamento;
            observacoesTextBox.Text = funcionario.Observacoes;
            fotoUrlImage.ImageUrl =
             string.Format("~/ imagens / funcionarios /{0}",funcionario.FotoPath);
            fotoUrlImage.Visible = true;
        }

        protected void funcionariosGridView_RowCommand( object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "detalhes")
            {
                Mensagem(null);
                int linha = Convert.ToInt32(e.CommandArgument);
                int funcionarioId = (int)funcionariosGridView
                .DataKeys[linha].Value;
                ExibirFuncionario(funcionarioId);

                incluirButton.Visible = false;
                AlterarButton.Visible = true;
                ExcluirButton.Visible = true;
            }
        }

        protected void AlterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var funcionario = ObterFuncionario();

                var db = new FuncionarioDb();

                db.Alterar(funcionario);

                funcionario =
                db.FuncionarioPorId(funcionario.FuncionarioID);
                Mensagem("Funcionário alterado com sucesso");
            }
            catch (Exception ex)
            {
                Mensagem(ex.Message);
            }
        }

        private void ExibirGrid()
        {
            formMultiView.ActiveViewIndex = 0;
        }

        void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new FuncionarioDb();
                int funcionarioId = (int)ViewState["funcionarioId"];
                db.Excluir(funcionarioId);
                AtualizarGrid();
                ExibirGrid();
                Mensagem("Funcionário Excluído com Sucesso");
            }
            catch (Exception ex)
            {
                Mensagem(ex.Message);
            }
        }



    }
}