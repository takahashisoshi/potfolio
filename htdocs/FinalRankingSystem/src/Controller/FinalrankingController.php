<?php
namespace App\Controller;

use App\Controller\AppController;

/**
 * Finalranking Controller
 *
 * @property \App\Model\Table\FinalrankingTable $Finalranking
 *
 * @method \App\Model\Entity\Finalranking[]|\Cake\Datasource\ResultSetInterface paginate($object = null, array $settings = [])
 */
class FinalrankingController extends AppController
{
    public function GetRanking(){
        $this->autoRender = false;

        $query = $this->Finalranking->find("all");

        $query->order(['score'=>'DESC']);

        $json = json_encode($query);

        echo $json;
        
    }

    public function SetRanking(){
        $this->autoRender = false;

        $postScore = $this->request->data["Score"];

        $record = array(
            "Score"=>$postScore,
            "Date"=>date("y/m/d H:i:s")
        );

        $prm1 = $this->Finalranking->newEntity();
        $prm2 = $this->Finalranking->patchEntity($prm1,$record);
        if( $this->Finalranking->save($prm2)){
            echo "1";
        }else{
            echo"0";
        }
    
        
        
    }
}
