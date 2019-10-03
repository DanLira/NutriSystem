import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CadastroNutricionistaComponent } from './cadastro-nutricionista/cadastro-nutricionista.component';
import { CadastroPacienteComponent } from './cadastro-paciente/cadastro-paciente.component';
import { CadastroConsultorioComponent } from './cadastro-consultorio/cadastro-consultorio.component';


const routes: Routes = [
  {
    path: 'cadastroNutricionista',
    component: CadastroNutricionistaComponent,
  },

  {
    path: 'paciente',
    component: CadastroPacienteComponent,
  },
  {
    path: 'cadastroConsultorio',
    component: CadastroConsultorioComponent,
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
