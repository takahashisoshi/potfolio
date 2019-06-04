<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Finalranking $finalranking
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Html->link(__('Edit Finalranking'), ['action' => 'edit', $finalranking->id]) ?> </li>
        <li><?= $this->Form->postLink(__('Delete Finalranking'), ['action' => 'delete', $finalranking->id], ['confirm' => __('Are you sure you want to delete # {0}?', $finalranking->id)]) ?> </li>
        <li><?= $this->Html->link(__('List Finalranking'), ['action' => 'index']) ?> </li>
        <li><?= $this->Html->link(__('New Finalranking'), ['action' => 'add']) ?> </li>
    </ul>
</nav>
<div class="finalranking view large-9 medium-8 columns content">
    <h3><?= h($finalranking->id) ?></h3>
    <table class="vertical-table">
        <tr>
            <th scope="row"><?= __('Id') ?></th>
            <td><?= $this->Number->format($finalranking->id) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('Score') ?></th>
            <td><?= $this->Number->format($finalranking->Score) ?></td>
        </tr>
        <tr>
            <th scope="row"><?= __('Date') ?></th>
            <td><?= h($finalranking->Date) ?></td>
        </tr>
    </table>
</div>
